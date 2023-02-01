FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Workflow.Sdk.sln /usr/src/
COPY Finbourne.Workflow.Sdk/Finbourne.Workflow.Sdk.csproj /usr/src/Finbourne.Workflow.Sdk/
RUN dotnet restore Finbourne.Workflow.Sdk

ENV FBN_WORKFLOW_API_URL ${FBN_WORKFLOW_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Workflow.Sdk

