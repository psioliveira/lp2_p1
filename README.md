
# 1º Projeto de Linguagens de Programação II 2018/2019
realizado por Pedro Siqueira P. Oliveira (a21705187)
Repositório Git: https://github.com/psioliveira/lp2_p1;

Projeto inteiramente feito por Pedro Siqueira Pereira de Oliveira.

## Descrição do problema

Os grupos devem implementar um programa em C# que
manipule e analise uma série de dados sobre jogos do Steam . O
programa deve começar por ler um ficheiro CSV, que contém os dados em
questão. O utilizador do programa pode depois colocar questões sobre os jogos,
como por exemplo, quais os jogos lançados a partir de determinada data, que
jogos suportam controlador, bem como efetuar algumas ações sobre jogos
específicos, como descarregar a imagem de apresentação do jogo.

## Objetivos

O projecto tem como objetivo a avaliação dos alunos da cadeira de Linguagem de Programação II
no quesito programação em linguagem C# com o material de ensino dado até a aua 8, no curso de Videojogos.

## Solução

Para este projeto foi gerado seis ficheiros de código dos quais:

1. Program.cs:
    
    Classe responsável pelo método main, onde decorre to programa em si.

2. Game.cs:
    
    Classe responsável por instanciar objetos com todas as variáveis de um dado jogo passadas a partir do ficheiro CSV assim como é responsável pelos métodos de imprimir todos os valores na linha de comandos e de salvar a imagem do jogo no desktop. 


3. Biblio.cs:
    
    Classe Responsável por gerar um Dicionário com todos os jogos passados pelo ficheiro csv, utilizando o campo ID como chave para pesquisa.
    Responsável por gerar uma lista com objetos Game para ser efectuada a pesquisa e o sorting.

4. Selection.cs:

    Classe responsável pelos métodos de pesquisa, organização e filtragem dos jogos na lista de jogos.
    Contém também o método para abrir as imagens do Desktop a partir do seu nome(ID do próprio game).

5. FileManager.cs:

    Classe responsável por verificar a abertura do ficheiro CSV e, caso consiga abri-lo, o devolve em formato de um conjunto de strings.

6. Renderer.cs:

    Classe responsável por imprimir no ecrã os menus do programa, assim como solicitar os inputs do usuário.




## Desenvolvimento

O programa pode foi desenvolvido em formato de Solução Visual Studio 2017, Console App (.NET framework).

O nome do ficheiro CSV é dado como 1º argumento na linha de comandos, caso 
não seja dado o caminho ao ficheiro o programa informa ao utilizador que não foi encontrado o path e o programa fecha. Caso o utilizador dê um caminho inválido o programa informa que o caminho é invalido e para o programa.

## UML



## Fluxograma

