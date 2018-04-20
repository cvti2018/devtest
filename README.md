# DevTest - Cadastro de EPI

Implemente os seguintes cadastros:

- Cadastro de empresa
- Cadastro de Fun��o
- Cadastro de Funcion�rio
- Associar um ou v�rios EPIs a um funcion�rio

No cadastro de funcion�rios mostrar os EPIs associados a esse funcion�rio.

Desej�vel para o desenvolvimento:
- Inje��o de depend�ncia
- TDD
- Persist�ncia dos dados e regras de neg�cio devem ser feitas no projeto CadastroEpi.Domain

---
## Informa��es gerais

1. Crie um branch e o utilize para enviar o c�digo ao finalizar. Favor enviar um email para avisar que o c�digo est� dispon�vel.
2. O banco de dados j� possui o cadastro de EPIs, n�o � necess�rio fazer o cadastro
3. Na tabela Funcion�rio EPI, a data de troca � a data que um EPI j� cadastrado foi substitu�do por outro do mesmo tipo (mesmo CA)

---
## Refer�ncias
- [TDD](https://en.wikipedia.org/wiki/Test-driven_development)
- Inje��o de depend�ncia
    - https://autofac.org/
    - https://simpleinjector.org
    - http://www.ninject.org/