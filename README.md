# Mestre dos códigos

# Criando projeto
> dotnet new sln
> dotnet new console -n ConsoleApp
> dotnet sln add ConsoleApp

# Rodando o projeto
> dotnet run -p ConsoleApp/

# Perguntas Teóricas:
## 1 - Em quais linguagens o C# foi inspirado?
Foi visto como uma atualização de C/C++ e teve alta inspiração na linguagem Java já que na época ele já possuia implementado parte das metas de design declaradas pelo ECMA que o C# buscava alcançar.<br>

## 2 - Inicialmente o C# foi criado para qual finalidade?
Inicialmente foi utilizado para ser uma linguagem simples e moderna, de propósito geral, Orientada a Objetos e fortemente tipada com muitas extensões adicionais para permitir também uma abordagem mais orientada a componentes.

Como dito no exercício anterior, ele buscava alcançar alguns objetivos de design definidos pelo ECMA.
Alguns design goals:
- Simples, Moderna e Para uso geral
- Orientada a Objetos
- Fortemente tipada
- Garbage collection automatica
- Suporte para internacionalização
- Adaptabilidade para os que ja estejam familiarizados com C/C++

## 3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
Maior utilização containers, maior liberdade para desenvolvimento multi-plataforma, configurações por CLI, escolhas de soluções não dependentes de UI como micro-serviços e necessidades de escalonamento.

## 4 - Cite as principais diferenças entre .Net Full Framework e .Net Core.
.NET Framework
- Mais simples
- Windows e Web Applications
- Aplicações centradas na interface do usuário
- Maior facilidade na utilização de API's para mexer em recursos do windows
 
.NET CORE
- Possui uma curva de aprendizagem
- Maior performance, sem UI
- Maior uso de linha de comando
- Maior aproveitamento de soluções não dependentes de UI e escalonamento
- open-source and cross-platform framework 

# Exercicio 1 sobre POO
## O que é POO?
Programação Orientada a Objeto é um paradigma de linguagem, onde trabalha com as ideias de objetos, que interagem si e/ou com outros objetos diferentes onde cada objeto pode possuir comportamentos e caracteristicas (Metodos e atributos). A linguagem de programação C# é multi paradigma possibilitando utilizar de recursos da orientação a objetos, como por exemplo: Abstrações, Classes, Encapsulamento, Heranças e Polimorfismo e também podendo utilizar de recursos dos paradigmas imperativo e funcional, assim dando uma maior maleabilidade na hora de desenvolver soluções de negócio.

Abaixo um exemplo da estrutura de uma classe:
```C#
// Definição da classe
public class ExemploClasse{

    // Construtor da classe: Comportamento que será chamado no momento de criação do objeto
    public ExemploClasse(string nomeDaClasse){
        this.nomeDaClasse = nomeDaClasse;
    }

    // Atributo (ou caracteristica) da classe, que servirá para armazenar valores que podem ou não ser alterados enquanto o objeto existir
    private string nomeDaClasse;

    // Metodo (ou comportamento) da classe, que irá realizar uma ação de responsabilidade do objeto ao ser chamado
    public string GetNomeDaClasse(){
        return nomeDaClasse;
    }

}
```

Abaixo os objetos que podem ser criados utilizando a estrutura acima como "esqueleto" para saber quais caracteristicas e comportamento possuem.

```C#
    var novoObjeto = new ExemploClasse("Hello World!");

    Console.WriteLine(novoObjeto.GetNomeDaClasse()); // Vai imprimir "Hello World!"
```

## O que é polimorfismo?
O conceito de polimorfismo vem da ideia de multiplas formas, onde um objeto pode parecer diferente de outro, porém ainda assim se comportar como  outros objetos mais abstratos, assim os tornando de certa forma iguais.

Um bom exemplo olhando para a realidade são os animais, onde uma galinha e um macaco são duas entidades diferentes, onde cada um possui caracteristicas diferentes e se comportam de forma diferente, porém olhando mais genericamente, ambos se alimentam, se movimentam, se reproduzem e se comunicam, claro que cada um faz essas ações de uma maneira diferente, mas conceitualmente eles possuem as mesmas ações a ser realizadas.
Ambos herdaram esse comportamento de uma entidade mais abstrata (que pode ser considerado o reino animal)

Quando pensamos em soluções polimórficas estamos pensando em soluções que não importa qual o comportamento específico de cada classe, mas pensamos em seus comportamentos genéricos.

Um exemplo abaixo:
```C#
public class AlimentadorDeAnimal{
    public void Alimentar(Animal animal){
        var comida = BuscarComidaParaOAnimal(animal);
        animal.Alimentar(comida);
    }
}

// Classe abstrata onde não posuí um comportamento específico, mas sabe que ele possui esse comportamento generico de se assustar
public abstract class Animal(){
    public abstract void Comer(Comida comida);
}

public class Galinha(){
    public void Comer(Comida comida){
        // Ação de ciscar
    }
}

public abstract class Macaco(){
    public void Comer(Comida comida){
        // Ação de comer
    }
}
```

## O que é abstração?
Abstração é o foco nos comportamentos e caracteristicas genéricas e essenciais para um objeto, ele serve como um modelo a ser seguido e implementado (ou não) os detalhes de como é feito de maneira separada por classes mais específicas que irão herdar seus comportamentos e atributos.

Para o polimorfismo a abstração é um conceito essencial, e no exemplo acima a classe abstrata é a classe `Animal`, onde ela define que tem uma ação `Alimentar` que é comum as classes mais específicas como a `Galinha` e o `Macaco`, sendo que cada classe específica realiza a ação `Alimentar` de sua forma específica.

## O que é encapsulamento?
Ele é um dos conceitos de programação orientada a objetos, onde ajuda o desenvolvimento de objetos que sejam consistentes, evitem modificações externas diretamente a suas caracteristicas e tornam os objetos responsáveis por suas próprias alterações evitando comportamentos inesperados de acontecer aos seus atributos.

Por exemplo, uma entidade de conta corrente, onde a cada operação realizada é descontado uma taxa tem um comportamento específico (Descontar taxa a cada operação) que deve ser seguido. Se ele permite que outros objetos façam alterações diretamente a seu atributo `Saldo` pode ser que não seja descontado a taxa, ou que o comportamento que está alterando o saldo da entidade esteja completamente diferente do que é esperado da entidade gerando vários problemas na aplicação.

O encapsulamento nesse exemplo pode ser aplicado mantendo as caracteristicas da entidade acessiveis apenas para o próprio objeto, e dando a possibilidade de fazer as alterações por comportamentos que estão dentro do próprio objeto, e que estes implementam toda lógica necessária para cada operação no saldo da conta.

__Exemplo pode ser visto na classe ContaCorrente utilizada no exercicio 3 dos exercicios de POO__

Entidade:
`PooModelos/Contas/ContaCorrente.cs`

Utilização:
`ExercicioPoo/Exercicios/Exercicio3.cs`

## Quando usar uma classe abstrata e quando devo usar uma interface?
Se utiliza uma classe abstrata quando é necessário herdar a implementação de comportamentos e/ou atributos mais genericos.

Classes abstratas podem definir como será feito a implementação de metodos, podendo ser sobreescritos por classes mais específicas. Dentro de interfaces apenas é dito quais serão os comportamentos e não como eles serão feitos (Foi feito uma proposta na específicação do C# 8.0 para implementação de métodos de interface padrão, recurso disponível no Java, mas ainda não foi implementado).

E é utilizado interface como um contrato que deverá ser cumprido para a utilização dela em outras classes que precisem daquele comportamento em específico (Podendo ser aplicado o polimorfismo em cima desse "contrato")

## O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
### IDisposable
Fornece um mecanismo para liberar recursos não gerenciados.

O uso principal dessa interface é liberar recursos não gerenciados. O coletor de lixo libera automaticamente a memória alocada para um objeto gerenciado quando esse objeto não é mais usado. No entanto, não é possível prever quando ocorrerá a coleta de lixo. Além disso, o coletor de lixo não tem conhecimento de recursos não gerenciados, como identificadores de janela, arquivos e fluxos abertos.

Implementando essa interface será necessário implementar os métodos:
- void Dispose();

__Utilizada em:__
- Componentes que possuem cuidados especiais para poder ser destruídos.
- Leitores de Arquivos.
- Conexões com banco de dados.

### IComparable
Define um método de comparação de tipo específico generalizado que implementa uma classe ou um tipo de valor para solicitar ou classificar suas instâncias.

Essa interface é implementada por tipos cujos valores podem ser ordenados ou classificados. Ele requer que os tipos de implementação definam um único método, CompareTo(Object) , que indica se a posição da instância atual na ordem de classificação é anterior, posterior ou igual a um segundo objeto do mesmo tipo. 

Implementando essa interface será necessário implementar os métodos:
- int CompareTo(object? obj);
__Utilizada em:__
- Array.Sort
- ArrayList.Sort
- Enumerable.OrderBy
- Enumerable.OrderByDescending

### ICloneable
Dá suporte à clonagem, que cria uma nova instância de uma classe com o mesmo valor de uma instância existente.

A ICloneable interface simplesmente requer que a implementação do Clone() método retorne uma cópia da instância do objeto atual. Ele não especifica se a operação de clonagem executa uma cópia profunda, uma cópia superficial ou algo entre. Nem requer que todos os valores de propriedade da instância original sejam copiados para a nova instância. Por exemplo, o Clone() método executa uma cópia superficial de todas as propriedades, exceto a IsReadOnly Propriedade; ela sempre define esse valor de propriedade como false no objeto clonado. Como os chamadores do Clone() não podem depender do método de execução de uma operação de clonagem previsível, recomendamos que ICloneable não seja implementado em APIs públicas.

Implementando essa interface será necessário implementar os métodos:
- object Clone();
__Utilizada em:__
A utilização de iClonable parece ser meio contráditória, vi vários foruns não recomendando a implementação, não consegui encontrar um lugar que utilize.

### IEnumerable
Expõe um enumerador que dá suporte a uma iteração simples em uma coleção não genérica.

Implementando essa interface será necessário implementar os métodos:
- IEnumerator<T> GetEnumerator();

Por sua vez, a entidade que ele retornar(IEnumerator) deverá implementar os métodos utilizado para iterar na lista:
- T Current { get; }
- bool MoveNext();
- object? Current { get; }
- void Reset();

__Utilizada em:__

## Existe herança múltipla (de classes) em C#?
C# Não permite heranças multiplas, utilizando outras linguagens tipo Python é possivel realizar herança multipla, porém para C# apenas é possível uma herança simples possuíndo apenas uma classe pai. 

# Principais ferramentas para utilização de testes no dotnet
https://docs.microsoft.com/pt-br/dotnet/core/testing/

Algumas ferramentas para testes: 

- xUnit: Cada metodo de teste é executado em uma classe separada, testes em paralelo
- nUnit: Todos os metodo de teste são executados na mesma classe, testes em sequencial
- MSTest: Desenvolvido pela microsoft, bem parecido com nUnit, possui algumas attributes diferentes, pode configurar execução de alguns métodos antes do assembly dos testes
- SpecFlow: Pode ser utilizado para fazer BDDs