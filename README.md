# dotnet-essentials
Some Essential Dotnet Codes

### namespace
- Namespace unico por projeto
- Normalmente o namespace segue o nome das pastas
- Importacao com 'using NameSpace'

### Variaveis
- Instanciacao com tipo (int, float, etc) ou var
- com tipo, ja comeca com valor definido, var comeca indefinido
- Nomear com nomes especificos e curtos
- Nao utilizar caracteres especiais e nem numero
- Convencao de nome: nomeDaVariavel

### Constantes
- Definido com 'const tipo NOME_DA_VARIAVEL'
- Convencao de escrita com Maiusculo separado por _

### Nomes Reservados
- keywords nao podem ser utilizados na criacao de variaveis

### Comentarios
- // ... //
- /* ... */
- XML (metadata)

### Tipos Primitivos
- Conhecidos como built-in types
- Simple Types, Enums, Structs, Nullable Types

### System
- Tipos devirivam do Systems
- Base dos tipos principais

### Byte
- Representa 1 byte = 8 bits
- sbyte permite valor negativo (s de signed)

### Numeros Inteiros
- short/ushort (u de unsigned) 16-bit
- int/uint 32-bit
- long/ulong 64-bit

### Numeros Reais
- float (Notacao F) 32-bit. valor com f no final. ex: float a = 2.5f
- double 64-bit
- decimal (Notacao M) 128-bit. valor com m no final. ex: decimal a = 2.5m

### Boolean
- bool = true ou false

### Char
- Armazena 1 caractere
- char a = 'a' (aspas simples)

### String
- Armazena cadeia de char
- string a = "aa" (aspas duplas)

### Var
- Atribui o tipo

### Object
- usado quando nao sabemos qual tipo sera a varivel

### Nullable types
- void (vazio, sem retorno)
- null (nulo, sem valor)
- ex: int? age = null (uso de intorrogacao no tipo)

### Alias
- apelidos
- ex: System.String = string

### Valores Padroes
- int => 0
- float => 0
- decimal => 0
- bool => false
- char => '\0'
- string => ""

### Conversao de Dados
- Conversao implicita > ex: 'de' tem que caber em 'para'
- Conversao explicita > ex: 'para' = (para)'de' > fazer casting
- Parse > ex: int integer = int.Parse("100")
- Convert > ex: int integer = Convert.ToInt32("100")

### Heap e Stack
- Heap armazena Dados
- Stack armazena referencia para dados
