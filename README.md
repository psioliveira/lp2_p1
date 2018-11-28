
# 1º Projeto de Linguagens de Programação II 2018/2019
realizado por Pedro Siqueira P. Oliveira (a21705187)
## Descrição do problema

Os grupos devem implementar um programa em C# que
manipule e analise uma série de dados sobre jogos do Steam . O
programa deve começar por ler um ficheiro CSV, que contém os dados em
questão. O utilizador do programa pode depois colocar questões sobre os jogos,
como por exemplo, quais os jogos lançados a partir de determinada data, que
jogos suportam controlador, bem como efetuar algumas ações sobre jogos
específicos, como descarregar a imagem de apresentação do jogo.

### Objetivos

O projecto tem como objetivo a avaliação dos alunos da cadeira de Linguagem de Programação II
no quesito programação em linguagem C# com o material de ensino dado até a aua 8, no curso de Videojogos.

#### Solução

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




##### Desenvolvimento

O programa pode foi desenvolvido em formato de Solução Visual Studio 2017, Console App (.NET framework).

O nome do ficheiro CSV é dado como 1º argumento na linha de comandos, caso 
não seja dado o caminho ao ficheiro o programa informa ao utilizador que não foi encontrado o path e o programa fecha. Caso o utilizador dê um caminho inválido o programa informa que o caminho é invalido e para o programa.


##### Especificar critério de ordenação



##### Especificar filtros de pesquisa

##### Realizar pesquisa

Quando é feita uma pesquisa o programa percorre a lista dos  jogos selecionados a partir do filtro e ordenado da maneira que foi solicitado e reorna 10 jogos para o utilizador e o pergunta se quer contnuar. Caso queira, o terminal é limpo e é impresso no ecrã os próximos 10 valores e assim por diante. Caso o utilizador não queira a pesquisa termina e o programa pergunta se o utilizador pretende fazer uma nova pesquisa.

## Objetivos e critério de avaliação

Este projeto tem os seguintes objetivos:

*   **O1** - Programa deve funcionar como especificado.
*   **O2** - Projeto e código bem organizados, nomeadamente:
    *   Estrutura de classes bem pensada (ver secção
        <a href="#orgclasses">Organização do projeto e estrutura de
        classes</a>).
    *   Código devidamente comentado e indentado.
    *   Inexistência de código "morto", que não faz nada, como por exemplo
        variáveis, propriedades ou métodos nunca usados.
    *   Projeto compila e executa sem erros e/ou *warnings*.
*   **O3** - Projeto adequadamente documentado. Documentação deve ser feita com
    [comentários de documentação XML][XML], e a documentação (gerada em formato
    HTML ou CHM com [Doxygen][], [Sandcastle][] ou ferramenta similar
    [\[5\]][ref5]) deve estar incluída no ZIP do projeto, mas **não** integrada
    no repositório Git.
*   **O4** - Repositório Git deve refletir boa utilização do mesmo, com
    *commits* de todos os elementos do grupo e mensagens de *commit* que sigam
    as melhores práticas para o efeito (como indicado
    [aqui](https://chris.beams.io/posts/git-commit/),
    [aqui](https://gist.github.com/robertpainsi/b632364184e70900af4ab688decf6f53),
    [aqui](https://github.com/erlang/otp/wiki/writing-good-commit-messages) e
    [aqui](https://stackoverflow.com/questions/2290016/git-commit-messages-50-72-formatting)). Quaisquer *assets* binários, tais como imagens, devem ser integrados
    no repositório em modo Git LFS.
*   **O5** - Relatório em formato [Markdown][] (ficheiro `README.md`),
    organizado da seguinte forma:
    *   Título do projeto.
    *   Nome dos autores (primeiro e último) e respetivos números de aluno.
    *   Indicação do repositório público Git utilizado. Esta indicação é
        opcional, pois podem preferir desenvolver o projeto num repositório
        privado.
    *   Informação de quem fez o quê no projeto. Esta informação é
        **obrigatória** e deve refletir os *commits* feitos no Git.
    *   Descrição da solução:
        *   Arquitetura da solução, com breve explicação de como o programa foi
            organizado, indicação das coleções usadas e porquê, bem como dos
            algoritmos utilizados (e.g., para fazer *parsing* do ficheiro CSV,
            para conjugar as várias perguntas à base de dados, etc).
        *   Um diagrama UML de classes simples (i.e., sem indicação dos
            membros da classe) descrevendo a estrutura de classes.
        *   Um fluxograma mostrando o funcionamento do programa.
    *   Conclusões e matéria aprendida.
    *   Referências, incluindo trocas de ideias com colegas, código aberto
        reutilizado (e.g., do StackOverflow) e bibliotecas de terceiros
        utilizadas. Devem ser o mais detalhados possível.
    *   **Nota:** o relatório deve ser simples e breve, com informação mínima e
        suficiente para que seja possível ter uma boa ideia do que foi feito.
        Atenção aos erros ortográficos, pois serão tidos em conta na nota
        final.

O projeto tem um peso de 2 valores na nota final da disciplina e será avaliado
de forma qualitativa. Isto significa que todos os objetivos têm de ser
parcialmente ou totalmente cumpridos. A cada objetivo, O1 a O5, será atribuída
uma nota entre 0 e 1. A nota do projeto será dada pela seguinte fórmula:

*N = 2 x O1 x O2 x O3 x O4 x O5 x D*

Em que *D* corresponde à nota da discussão e percentagem equitativa de
realização do projeto, também entre 0 e 1. Isto significa que se os alunos
ignorarem completamente um dos objetivos, não tenham feito nada no projeto ou
não comparerecem na discussão, a nota final será zero.

## Entrega

O projeto deve ser entregue por **grupos de 2 alunos** via Moodle até às 23h de
18 de novembro de 2018. Deve ser submetido um ficheiro `zip` com os seguintes
conteúdos:

*   Solução completa do projeto, contendo adicionalmente e obrigatoriamente:
    *   Pasta escondida `.git` com o repositório Git local do projeto.
    *   Documentação HTML ou CHM gerada com [Doxygen][], [Sandcastle][] ou
        ferramenta similar [\[5\]][ref5].
    *   Ficheiro `README.md` contendo o relatório do projeto em formato
        [Markdown][].
    *   Ficheiros de imagem contendo o fluxograma e o diagrama UML de classes.
        Estes ficheiros podem ser incluídos no repositório em modo Git LFS.

## Honestidade académica

Nesta disciplina, espera-se que cada aluno siga os mais altos padrões de
honestidade académica. Isto significa que cada ideia que não seja do
aluno deve ser claramente indicada, com devida referência ao respectivo
autor. O não cumprimento desta regra constitui plágio.

O plágio inclui a utilização de ideias, código ou conjuntos de soluções
de outros alunos ou indivíduos, ou quaisquer outras fontes para além
dos textos de apoio à disciplina, sem dar o respectivo crédito a essas
fontes. Os alunos são encorajados a discutir os problemas com outros
alunos e devem mencionar essa discussão quando submetem os projetos.
Essa menção **não** influenciará a nota. Os alunos não deverão, no
entanto, copiar códigos, documentação e relatórios de outros alunos, ou dar os
seus próprios códigos, documentação e relatórios a outros em qualquer
circunstância. De facto, não devem sequer deixar códigos, documentação e
relatórios em computadores de uso partilhado.

Nesta disciplina, a desonestidade académica é considerada fraude, com
todas as consequências legais que daí advêm. Qualquer fraude terá como
consequência imediata a anulação dos projetos de todos os alunos envolvidos
(incluindo os que possibilitaram a ocorrência). Qualquer suspeita de
desonestidade académica será relatada aos órgãos superiores da escola
para possível instauração de um processo disciplinar. Este poderá
resultar em reprovação à disciplina, reprovação de ano ou mesmo suspensão
temporária ou definitiva da ULHT.

*Texto adaptado da disciplina de [Algoritmos e
Estruturas de Dados][aed] do [Instituto Superior Técnico][ist]*

## Referências

*   <a name="ref1">\[1\]</a> Whitaker, R. B. (2016). **The C# Player's Guide**
    (3rd Edition). Starbound Software.
*   <a name="ref2">\[2\]</a> Albahari, J. (2017). **C# 7.0 in a Nutshell**.
    O’Reilly Media.
*   <a name="ref3">\[3\]</a> Kelly, C. (2016). **Steam Game Data**. Retrieved
    from <https://data.world/craigkelly/steam-game-data>.
*   <a name="ref4">\[4\]</a> Freeman, E., Robson, E., Bates, B., & Sierra, K.
    (2004). **Head First Design Patterns**. O'Reilly Media.
*   <a name="ref5">\[5\]</a> Dorsey, T. (2017). **Doing Visual Studio and .NET
    Code Documentation Right**. Visual Studio Magazine. Retrieved from
    <https://visualstudiomagazine.com/articles/2017/02/21/vs-dotnet-code-documentation-tools-roundup.aspx>.

## Licenças

Este enunciado é disponibilizados através da licença [CC BY-NC-SA 4.0][].

## Metadados

*   Autor: [Nuno Fachada][]
*   Curso:  [Licenciatura em Videojogos][lamv]
*   Instituição: [Universidade Lusófona de Humanidades e Tecnologias][ULHT]

[ref1]:#ref1
[ref2]:#ref2
[ref3]:#ref3
[ref4]:#ref4
[ref5]:#ref5
[CC BY-NC-SA 4.0]:https://creativecommons.org/licenses/by-nc-sa/4.0/
[lamv]:https://www.ulusofona.pt/licenciatura/videojogos
[Nuno Fachada]:https://github.com/fakenmc
[ULHT]:https://www.ulusofona.pt/
[aed]:https://fenix.tecnico.ulisboa.pt/disciplinas/AED-2/2009-2010/2-semestre/honestidade-academica
[ist]:https://tecnico.ulisboa.pt/pt/
[Markdown]:https://guides.github.com/features/mastering-markdown/
[Doxygen]:https://www.stack.nl/~dimitri/doxygen/
[Sandcastle]:https://github.com/EWSoftware/SHFB
[SRP]:https://en.wikipedia.org/wiki/Single_responsibility_principle
[KISS]:https://en.wikipedia.org/wiki/KISS_principle
[CSV]:https://en.wikipedia.org/wiki/Comma-separated_values
[`DateTime`]:https://docs.microsoft.com/dotnet/api/system.datetime
[`int`]:https://docs.microsoft.com/dotnet/api/system.int32
[`Uri`]:https://docs.microsoft.com/dotnet/api/system.uri
[`bool`]:https://docs.microsoft.com/dotnet/api/system.boolean
[`string`]:https://docs.microsoft.com/dotnet/api/system.string
[`List<T>`]:https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1
[`IEnumerable<T>`]:https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[`HashSet<T>`]:https://docs.microsoft.com/dotnet/api/system.collections.generic.hashset-1
[DIP]:https://en.wikipedia.org/wiki/Dependency_inversion_principle
[XML]:https://docs.microsoft.com/dotnet/csharp/codedoc
[`WebClient`]:https://docs.microsoft.com/dotnet/api/system.net.webclient
[`Process`]:https://docs.microsoft.com/dotnet/api/system.diagnostics.process
