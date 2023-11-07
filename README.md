## Após alterações relacionadas ao banco de dados

dotnet ef migrations add {* => nome especificando alteração <= *} --project apiFuncionarios
dotnet ef database update --project apiFuncionarios
