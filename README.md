###### _
![](https://github.com/is-leeroy-jenkins/Kitty/blob/master/Project/Resources/Images/Github/HaloKittyAdventures.png)
#  MVC Starter Kit  
*“Because every **Hello World** deserves Major-grade armor.”*

**Kitty** provides production-ready boilerplate for **ASP.NET Core 8 MVC** web-applications.  
Inspired by a crossover of **Hello Kitty** and Halo's **Master Chief**, Kitty cute and quick scaffolding with the fire-power of enterprise-grade architecture—so you can obliterate boilerplate and conquer the task at hand.

<div align="center">
  <img src="https://github.com/is-leeroy-jenkins/Kitty/blob/master/Project/Resources/Images/Github/HaloKittyIcon_128px.png" width="100" alt="Kitty – Hello Kitty x Master Chief fan-art">
  <br/>
  <sup>Halo Kitty  © Microsoft &amp <br/>No affiliation or endorsement implied.</sup>
</div>

---

## ✨ Features at a Glance

| 🗂 Category              | 🎁 What Kitty Ships                                                                              |
|-------------------------|--------------------------------------------------------------------------------------------------|
| **Framework**           | ASP.NET Core 8 MVC Areas + Controllers + Razor Views                                             |
| **UI/Styling**          | Bootstrap 5 + ViewComponents + TagHelpers                                                        |
| **Front-End**           | ESBuild for JS/TS; Sass pipeline; LiveReload via `dotnet watch`                                  |
| **Auth**                | ASP.NET Core Identity + external OAuth (Google/Microsoft) stubs                                 |
| **Data Access**         | EF Core 8 with PostgreSQL (dev swap-able to SQLite)                                              |
| **Testing**             | xUnit + Shouldly + Selenium (UI smoke tests)                                                    |
| **Validation**          | FluentValidation + unobtrusive client-side integration                                          |
| **API Slice**           | Minimal APIs under `/api` for SPA/mobile BFF scenarios                                          |
| **Email**               | Razor-templated emails (Liquid) + Postal-Core + MailKit driver                                  |
| **Observability**       | Serilog sinks to Console ✓ Seq ✓ OTLP ✓                                                         |
| **DevOps**              | GitHub Actions workflow → build • test • publish multi-arch Docker image                        |
| **Cloud Ready**         | Helm chart + K8s manifests example; HealthChecks & readiness probes                             |

---

## 🎯 Why Kitty?

* **Opinionated but untethered** – follow conventions out-of-box, yet every dependency is swappable.  
* **MVC-first** – built for server-rendered apps that still need sprinkles of JS for snappy UX.  
* **Full-stack in one repo** – controllers, views, APIs, background workers & infra configs co-located.  
* **Ready to demo, ready for prod** – HTTPS, security headers, logging, and migrations.

---

## 🚀 Quick Start

### Prerequisites

| Tool           | Version | Notes                                |
|----------------|---------|--------------------------------------|
| .NET SDK       | **8.0.x** | <https://dotnet.microsoft.com/download> |
| Node.js        | ≥ 18    | For Sass & ESBuild                   |
| Docker         | ≥ 24    | (optional) containers        |


### ![](https://github.com/is-leeroy-jenkins/Kitty/blob/master/Project/Resources/Images/Github/install.png) Installation

```bash
dotnet new install Kitty       # 1st time only
dotnet new kitty -n Kitty
cd Kitty
dotnet watch                    # Live reload incl. Sass & ESBuild
```

### ![](https://github.com/is-leeroy-jenkins/Kitty/blob/master/Project/Resources/Images/Github/csharp.png) Code
- [Controller](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Controller]) - main UI layer with numerous controls and related functionality.
- [Models](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Models) - XAML-based styles for the Badger UI layer.
- [Enumerations](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Enumerations) - various enumerations used by Kitty.
- [Extensions](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Extensions)- useful extension methods for budget analysis by type.
- [IO](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/IO) - input output classes used for networking and the file systemm.
- [Static](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Static) - static types used in the analysis of environmental budget data.
- [Abstractions](https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Abstractions) - interfaces and base-classes used in the analysis of environmental budget data.
- [Views]((https://github.com/is-leeroy-jenkins/Kitty/tree/master/Project/Views)) - UI layer for Kitty

___

### ![](https://github.com/is-leeroy-jenkins/Kitty/blob/master/Project/Resources/Images/Github/icons8-layers-30.png) Directory Structure
```/
├─ src/
│  ├─ Acme.Web/            # MVC web-app: Controllers, Views, Areas, TagHelpers
│  ├─ Acme.Core/           # Domain models, services, validation
│  ├─ Acme.Infrastructure/ # EF DbContext, repositories, email, external connectors
│  └─ Acme.Worker/         # Background service sample (queued emails, jobs)
├─ tests/
│  ├─ Unit/                # Core + infra tests (xUnit)
│  └─ UiSmoke/             # Selenium smoke suite
└─ deploy/
   ├─ docker-compose.yml   # Dev stack (Postgres + Seq + app)
   └─ helm/                # Kubernetes chart
```

___

### ⚙️ Configuration Matrix
 Setting | File / Provider | Purpose
--------- | --------- | ---------
Conn string (Default) | appsettings.*.json / secrets | PostgreSQL connection
JwtSettings:* | appsettings.json / vault | Token auth for Minimal APIs
Email SMTP creds | dotnet user-secrets in dev | MailKit configuration
Serilog sinks & levels | appsettings.Production.json | Logging targets inc. OTLP exporter
Feature flags | appsettings.json | Toggle optional modules


___ 

### 🛠️ Commands
Command | Description
------- | -----------
dotnet watch | Hot reload + front-end pipeline
npm run build:css | Compile/minify Sass (CI)
dotnet ef migrations add | Create EF migration
docker compose up -d | Bring up Postgres + Seq + app
dotnet test | Run unit tests
npm run lint | ESLint & Stylelint (optional)

### 🧪 Testing
- IdentityServer template for enterprise SSO
- Blazor-based admin area
- Redis cache / session provider option
- gRPC service stub
___

### 🐛 Contributing
#### PRs welcome!
- Fork → feature branch → lint+tests green → PR w/ description.
- Follow .editorconfig (StyleCop-analyzers enabled).
- Sign your commits (git commit -s).

___
