# ANIMAL-HEALTH-PROTOFILES
## Протофайлы для КЛИЕНТА/СЕРВЕРА.
---
## 1. НЕОБХОДИМЫЕ ЗАВИСИМОСТИ:
- Google.Protobuf:
```cli
dotnet add package Google.Protobuf --version 3.25.1
```
- Grpc.AspNetCore (для сервера на ASP):
```cli
dotnet add package Grpc.AspNetCore --version 2.59.0
```
- Grpc.Net.Client (для клиента):
```cli
dotnet add package Grpc.Net.Client --version 2.59.0
```
- Grpc.Tools:
```cli
dotnet add package Grpc.Tools --version 2.59.0
```
## 2. УСТАНОВКА PROTO-ФАЙЛОВ:
2.1. Скачать все proto-файлы.

2.2. Перенести все файлы в папку проекта. (Для примера: ./ProtoProject/Protos/);

2.3. Ввести зависимости в .csproj.
```xml
  <Protobuf Include="Путь до proto" GrpcServices="Server (или Client)"/>
```

Пример:
```xml
    <ItemGroup>
        <Protobuf Include="Protos\greet.proto" GrpcServices="Server"/>
        <Protobuf Include="Protos\animal.proto" GrpcServices="Server"/>
    </ItemGroup>
```

Для данных Protofiles:
```xml
<ItemGroup>
  <Protobuf Include="Protos\greet.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\animal.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\contract.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\infrastructure.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\inspection.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\locality.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\organization.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\pricePair.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\role.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\user.proto" GrpcServices="Server (или клиент)"/>
  <Protobuf Include="Protos\vaccination.proto" GrpcServices="Server (или клиент)"/>
</ItemGroup>
```
