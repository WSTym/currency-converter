# Currency Converter 💱

Um simples e eficiente **Conversor de Moedas** desenvolvido em **Windows Forms** com **.NET 8.0**.  
Este projeto utiliza uma API de taxas de câmbio para fornecer conversões em tempo real entre moedas.

## 📋 Funcionalidades
- **Seleção de moedas**: Escolha entre USD, EUR, BRL, GBP (pode ser expandido facilmente).  
- **Conversão em tempo real**: Insira o valor e veja o resultado imediatamente.  
- **Histórico de conversões**: Visualize os valores já convertidos.  
- **Interface moderna**: Layout limpo e responsivo para fácil utilização.

## 🛠️ Tecnologias Utilizadas
- **C#** com **Windows Forms**  
- **.NET 8.0**  
- **API Exchangerate-API** para taxas de câmbio (ou similar).  

## 🎨 Captura de Tela
![image](https://github.com/user-attachments/assets/ec1533be-4f84-4c01-bcf1-9c26615a4415)

## 🚀 Como Rodar o Projeto
1. Clone este repositório:  

   ```bash
   git clone https://github.com/seuusuario/currency-converter.git
   cd currency-converter
   
3. Abra o projeto no Visual Studio.  
4. Certifique-se de que possui o **.NET 8.0 SDK** instalado.  
5. Adicione sua chave da API (se necessário) no arquivo `FormCurrencyConverter.cs`, na variável `ApiUrl`:  

   ```csharp
   private const string ApiUrl = "https://api.exchangerate-api.com/v4/latest/";
   
7. Compile e execute o projeto.  

## 🧪 Testando o Conversor
- Escolha as moedas no menu suspenso.  
- Insira o valor desejado no campo de entrada.  
- Clique em **Convert** para realizar a conversão.  
- Veja o resultado no painel de **Resultado** e o histórico no painel inferior.

## 🔧 Como Expandir
- **Adicionar novas moedas**: Insira novos códigos de moedas no `ComboBox`.  
- **Alterar API**: Atualize a URL e a lógica de processamento em `GetExchangeRate`.  
- **Exportar histórico**: Adicione um botão para salvar o histórico em um arquivo `.txt` ou `.csv`.

## 🤝 Contribuindo
1. Faça um fork deste repositório.  
2. Crie uma branch para sua feature (`git checkout -b minha-feature`).  
3. Commit suas alterações (`git commit -m 'Minha nova feature'`).  
4. Envie para a branch principal (`git push origin minha-feature`).  
5. Abra um Pull Request.  

## 📝 Licença
Este projeto é licenciado sob a **MIT License** - veja o arquivo [LICENSE](LICENSE) para detalhes.

