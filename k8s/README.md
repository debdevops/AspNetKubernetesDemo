# ASP.NET Core Kubernetes Demo

![.NET](https://img.shields.io/badge/.NET-9.0-blue)
![Kubernetes](https://img.shields.io/badge/Kubernetes-1.28+-326CE5)
![Docker](https://img.shields.io/badge/Docker-20.10+-2496ED)

A demonstration of deploying ASP.NET Core microservices to Kubernetes, featuring:
- **ProductsAPI** - Product catalog service
- **OrdersAPI** - Order processing service
- **UsersAPI** - User management service

## 🚀 Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (with Kubernetes enabled)
- [kubectl](https://kubernetes.io/docs/tasks/tools/) (included with Docker Desktop)
- [VS Code](https://code.visualstudio.com/) (recommended)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/AspNetKubernetesDemo.git
   cd AspNetKubernetesDemo

docker build -t products-api -f ProductsAPI/Dockerfile .
docker build -t orders-api -f OrdersAPI/Dockerfile .
docker build -t users-api -f UsersAPI/Dockerfile .

kubectl apply -f k8s/

kubectl get all

kubectl port-forward service/products-service 8080:80
kubectl port-forward service/orders-service 8081:80
kubectl port-forward service/users-service 8082:80

API Endpoints
Service	Swagger UI	Sample Endpoint
ProductsAPI	http://localhost:8080/swagger	GET /products
OrdersAPI	http://localhost:8081/swagger	GET /orders
UsersAPI	http://localhost:8082/swagger	GET /users

AspNetKubernetesDemo/
├── ProductsAPI/          # Product catalog service
├── OrdersAPI/            # Order processing service
├── UsersAPI/             # User management service
├── k8s/                  # Kubernetes manifests
│   ├── products-deployment.yaml
│   ├── products-service.yaml
│   ├── orders-deployment.yaml
│   ├── ...
├── README.md             # This file
└── AspNetKubernetesDemo.sln