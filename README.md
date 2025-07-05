# 🧾 Explicação do Código em C# Operadores lógicos

Este código demonstra o uso de operadores lógicos em C# (`||`, `&&`, `!`) com exemplos práticos.

---

## ✅ Verificação de Entrada

```csharp
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}
```

- **Objetivo:** Verificar se a pessoa pode entrar.
- **Operador usado:** `||` (OR)
- **Lógica:** A entrada será liberada se a pessoa for maior de idade **ou** tiver autorização do responsável.
- **Resultado:**  
  Como `ehMaiorDeIdade` é `true`, imprime:  
  **`Entrada liberada`**

---

## 🎓 Verificação de Aprovação

```csharp
bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
```

- **Objetivo:** Verificar se o aluno foi aprovado.
- **Operador usado:** `&&` (AND)
- **Lógica:** O aluno será aprovado se tiver presença mínima **e** média maior ou igual a 7.
- **Resultado:**  
  Ambas as condições são verdadeiras, então imprime:  
  **`Aprovado!`**

---

## 🚴‍♂️ Decisão de Pedalar

```csharp
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}
```

- **Objetivo:** Decidir se vai pedalar.
- **Operadores usados:** `!` (NOT) e `&&` (AND)
- **Lógica:** A pessoa só vai pedalar se **não** estiver chovendo **e** **não** estiver tarde.
- **Resultado:**  
  Como ambas são `false`, o `!` inverte para `true`, então imprime:  
  **`Vou pedalar!!`**

---

## 🧠 Resumo dos Operadores Lógicos

| Operador | Nome       | Exemplo     | Significado                                                                 |
|----------|------------|-------------|------------------------------------------------------------------------------|
| `\|\|`     | OR         | `A \|\| B`    | Verdadeiro se **pelo menos uma** das condições for verdadeira               |
| `&&`     | AND        | `A && B`    | Verdadeiro **somente se ambas** as condições forem verdadeiras              |
| `!`      | NOT        | `!A`        | Inverte o valor lógico (se `A` é `true`, `!A` é `false`, e vice-versa)       |

---

Se quiser, posso adicionar exemplos com entrada do usuário ou transformar isso em um mini projeto interativo. Quer seguir por esse caminho? 🚀
