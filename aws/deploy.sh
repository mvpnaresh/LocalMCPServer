#!/bin/bash
set -e

# ─── Configuration ───────────────────────────────────────────────────────────
AWS_REGION="${AWS_REGION:-us-east-1}"
AWS_ACCOUNT_ID=$(aws sts get-caller-identity --query Account --output text)
ECR_REPO="local-mcp-server"
IMAGE_TAG="${IMAGE_TAG:-latest}"
CLUSTER="${ECS_CLUSTER:-mcp-cluster}"
SERVICE="${ECS_SERVICE:-mcp-service}"

ECR_URI="${AWS_ACCOUNT_ID}.dkr.ecr.${AWS_REGION}.amazonaws.com/${ECR_REPO}"

echo "==> Logging into ECR..."
aws ecr get-login-password --region "$AWS_REGION" \
  | docker login --username AWS --password-stdin "${AWS_ACCOUNT_ID}.dkr.ecr.${AWS_REGION}.amazonaws.com"

echo "==> Creating ECR repository (if not exists)..."
aws ecr describe-repositories --repository-names "$ECR_REPO" --region "$AWS_REGION" 2>/dev/null \
  || aws ecr create-repository --repository-name "$ECR_REPO" --region "$AWS_REGION"

echo "==> Building Docker image..."
cd "$(dirname "$0")/.."
docker build -t "${ECR_REPO}:${IMAGE_TAG}" .

echo "==> Tagging and pushing image..."
docker tag "${ECR_REPO}:${IMAGE_TAG}" "${ECR_URI}:${IMAGE_TAG}"
docker push "${ECR_URI}:${IMAGE_TAG}"

echo "==> Registering ECS task definition..."
# Replace placeholders in task definition
sed \
  -e "s|<ACCOUNT_ID>|${AWS_ACCOUNT_ID}|g" \
  -e "s|<REGION>|${AWS_REGION}|g" \
  aws/ecs-task-definition.json > /tmp/task-def.json

TASK_DEF_ARN=$(aws ecs register-task-definition \
  --cli-input-json file:///tmp/task-def.json \
  --region "$AWS_REGION" \
  --query 'taskDefinition.taskDefinitionArn' \
  --output text)

echo "==> Task definition registered: $TASK_DEF_ARN"

echo "==> Updating ECS service..."
aws ecs update-service \
  --cluster "$CLUSTER" \
  --service "$SERVICE" \
  --task-definition "$TASK_DEF_ARN" \
  --region "$AWS_REGION"

echo "==> Deployment complete!"
echo "    Image: ${ECR_URI}:${IMAGE_TAG}"
echo "    Task:  ${TASK_DEF_ARN}"
