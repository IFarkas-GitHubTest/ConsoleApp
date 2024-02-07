# BM.Libs.Extensions project notes

## GitHub Login

*SSO:* https://github.com/orgs/BrandsMart-USA/sso
*GitHub:* https://github.com/BrandsMart-USA

## Set GitHub variables and secrets in local environment variables

Request secrets from project manager.

```powershell
[Environment]::SetEnvironmentVariable('Git_Username', 'GitHub Action', 'User')
[Environment]::SetEnvironmentVariable('Git_Email', 'action@github.com', 'User')
[Environment]::SetEnvironmentVariable('GH_PKG_USER', 'BrandsMart-USA', 'User')
[Environment]::SetEnvironmentVariable('GH_PKG_TOKEN', 'ghp_XXX...', 'User')
[Environment]::SetEnvironmentVariable('SonarOrganization', 'BrandsMart', 'User')
[Environment]::SetEnvironmentVariable('SONAR_TOKEN_BM_Libs_Extensions', 'd{40}', 'User')
```

## GitHub CLI Login

```powershell
$Env:GH_PKG_TOKEN | gh auth login --with-token
```

## Setup Project

```powershell
cd C:\Projects\BrandsMart\Lib\BM.Libs.Extensions
git remote add origin https://github.com/BrandsMart-USA/BM.Libs.Extensions.git
git branch -M main
gh secret set GH_PKG_TOKEN --body "$Env:GH_PKG_TOKEN" -R BrandsMart-USA/BM.Libs.Extensions
gh secret set SONAR_TOKEN --body "$Env:SONAR_TOKEN_BM_Libs_Extensions" -R BrandsMart-USA/BM.Libs.Extensions
gh variable set GH_PKG_USER --body "$Env:GH_PKG_USER" -R BrandsMart-USA/BM.Libs.Extensions
gh variable set GIT_EMAIL --body "$Env:Git_Email" -R BrandsMart-USA/BM.Libs.Extensions
gh variable set GIT_USERNAME --body "$Env:Git_Username" -R BrandsMart-USA/BM.Libs.Extensions
gh variable set SONAR_ORGANIZATION --body "$Env:SonarOrganization" -R BrandsMart-USA/BM.Libs.Extensions
gh variable set VERSIONIZE --body "BMVersionize" -R BrandsMart-USA/BM.Libs.Extensions
gh variable set NET_FRAMEWORK_ARG --body " " -R BrandsMart-USA/BM.Libs.Extensions
dotnet new tool-manifest --force
dotnet tool install Husky
dotnet husky install
```
