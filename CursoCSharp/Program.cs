﻿using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controles
                {"Estrutura IF - Estruturas de Controles", EstruturaIf.Executar},
                {"Estrutura IF/Else - Estruturas de Controles", EstruturaIfElse.Executar},
                {"Estrutura IF/Else/If - Estruturas de Controles", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controles", EstruturaSwitch.Executar},
                {"Estrutura Do While - Estruturas de Controles", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controles", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controles", EstruturaForEach.Executar},
                {"Usando break - Estruturas de Controles", UsandoBreak.Executar},
                {"Usando continue - Estruturas de Controles", UsandoContinue.Executar},
                
                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", Desafiotributos.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNoeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                
                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                
                // OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Classe Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                 // Métodos e Funções
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegate - Métodos e Funções", LambdaDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegates Como Funções Anônimas - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegates Como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                 // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar}, 
                
                // API
                {"Primeira Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivo.Executar},
                {"Exemplo File Info - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                // LINK
                {"LINQ #1 - Usando API", LINQ1.Executar},
                {"LINQ #2 - Usando API", LINQ2.Executar},
                {"Nullables - Usando API", Nullables.Executar},
                {"Dynamics - Usando API", Dynamics.Executar},
                {"Genéricos - Usando API", Genericos.Executar},
            });


            central.SelecionarEExecutar();
        }
    }
}