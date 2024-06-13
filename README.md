# Gerador de Testes

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

---
## Descrição

Mariana prepara diversos exercícios para suas filhas que estão na 1ª e 2ª séries.
Ela gostaria de informatizar esses exercícios, para gerar testes aleatórios.
Cada teste  gerado deve ser guardado (acompanhado de suas questões), com a indicação de sua data de geração.
Na geração de um teste, é preciso informar o número de questões desejadas e qual disciplina pertence ao teste.

## Funcionalidades

1. O cadastro de **Disciplinas** consiste de:
	- nome

	1.1. O campo nome é obrigatório.

	1.2. Não pode registrar uma disciplina com o mesmo nome.

	1.3. A disciplina deve armazenar informações sobre as matérias que serão relacionadas à ela posteriormente.

	1.4. Não deve ser possível excluir disciplinas com matérias e testes relacionados.   

2. O cadastro de **Matérias** consiste de:
	- nome
	- disciplina
	- série

	2.1. Todos os campos são obrigatórios.

	2.2. Não pode registrar uma matéria com o mesmo nome.   

	2.3. Não deve ser possível excluir matérias sendo utilizadas em questões.
   
3. O cadastro de **Questões** consiste de:
	- matéria
	- enunciado
	- alternativas

	3.1. Todos os campos são obrigatórios.

	3.2. Cada questão deve ter um mínimo e máximo de alternativas (máximo sugerido: 4).
         
	3.3. Deve permitir adicionar alternativas à questão.

	3.4. Deve permitir remover alternativas à questão.

	3.5. Não permitir o cadastro de questões sem uma alternativa correta.

	3.6. Não deve permitir o cadastro de mais de uma alternativa correta.

	3.7. No mínimo duas alternativas devem ser configuradas.

	3.8. Não deve ser possível excluir uma questão relacionada a um teste.   
   
4. O cadastro de **Testes** consiste de:
	- título
	- disciplina
	- matéria*
	- série
	- quantidade de questões

	4.1. Deve ser informado a quantidade de questões que deverão ser geradas.

	4.2. Não pode registrar um teste com o mesmo nome.

	4.3. A quantidade de questões informada deve ser menor ou igual a quantidade de questões cadastradas.

	4.4. As matérias devem ser carregadas a partir da disciplina selecionada.

	4.5. Não deve permitir selecionar uma matéria que não pertença a disciplina selecionada.

	4.6. Caso a disciplina seja alterada, o campo matéria deve ficar em branco.

	4.7. Caso seja “Prova de Recuperação” deve considerar as questões de todas as matérias da disciplina selecionada.

	4.8. Todos os campos são obrigatórios.

	4.9. As questões devem ser selecionadas de forma aleatória.

	4.10. Deve permitir duplicar testes.
   	- na duplicação do teste o título, disciplina, quantidade de questões, série, prova de recuperação e matéria deverão vir preenchidos
   	- não pode duplicar um teste com o mesmo nome
   	- na duplicação do teste, as questões devem vir em branco

	4.11. Deve permitir duplicar testes.
   	- na duplicação do teste o título, disciplina, quantidade de questões, série, prova de recuperação e matéria deverão vir preenchidos
   	- não pode duplicar um teste com o mesmo nome
   	- na duplicação do teste, as questões devem vir em branco

	4.12. Deve ser possível visualizar os testes individualmente, com informações detalhadas incluindo as questões.

	4.13. Deve ser possível gerar PDF dos testes.
   	- o arquivo PDF do teste deve apresentar: título, disciplina, matéria, as questões e suas as alternativas
  
	4.14. Deve ser possível gerar PDF do gabarito dos testes.
   	- o arquivo PDF do gabarito do teste deve apresentar: título, disciplina, matéria, as questões e suas alternativas (com a alternativa correta assinalada)
---

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
git clone https://github.com/Marea-Turbo1343/GeradordeTestes2024.git
```

#### Navegue até a pasta raiz da solução
```
cd geradordetestes2024
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd GeradordeTestes.WinApp
```

#### Execute o projeto
```
dotnet run
```
