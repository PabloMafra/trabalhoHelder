## Após alterações relacionadas ao banco de dados

Add-Migration InitialDB -Context SistemaDBContext {* => nome do DBContext <= *}
dotnet ef migrations add branchCamila --project ProjetoGuardaChuva
dotnet ef database update --project apiFuncionarios
