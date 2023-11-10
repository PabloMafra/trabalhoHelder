## Após alterações relacionadas ao banco de dados

Add-Migration InitialDB -Context {* => nome do DBContext <= *}
dotnet ef migrations add tabelaEstoque --project apiFuncionarios
dotnet ef database update --project apiFuncionarios
