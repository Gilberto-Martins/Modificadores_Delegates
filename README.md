# Modificadores_Delegates

##

# Modificadores

<strong>ReadOnly</strong> = Bloqueia um caompo contra alterações que não <br>
seja em sua inicialização ou pelo próprio construtor.

Não permite que seja alterado se não for onde esta delcarado o ReadOnly.

Exemplo: <strong>public readonly string nome = "Fulano";</strong>

Constante = Representa um valor que somente pode ser atribuído  no momento de <br>
sua inicialização, e não pode ser modificado posteriormente.

Exemplo : <strong>Const string nome = "Fulana";</strong>

##

# Delegates

Um <strong>Delegate</strong> é uma maneira de passar um método como refeência, podendo ser usado <br>
como um callback, aceitando qualquer método que contenha a mesma assinatura.

<strong>Multi Cast Delegate</strong> = é chamar varios metodos em sequencia em uma unica chamada no delegate

## 

# Eventos

<strong>Eventos</strong> é um mecanismo de comunicação entre objetos, onde existe <br>
um publisher(quem vai criar o evento), que realiza o evento e o <br>
subscriber(quem vai escutar esse evento), que inscreve em um evento.

Um evento internamente usa um <strong>Delegate</strong> então vamos usar uma para cria um evento

