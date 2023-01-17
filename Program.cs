using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var contatos = new List<string>()
{
    "Rascunho ~"
};

// Acessar a página certa em que o WA está sendo utilizado
//https://www.lambdatest.com/blog/selenium-c-tutorial-handling-multiple-browser-windows/#:~:text=Handling%20Multiple%20Browser%20Windows%20In%20Selenium%20C%23,-The%20fundamental%20principles&text=To%20switch%20the%20context%20from,browser%20window%20(or%20tab).
var driver = new ChromeDriver();
driver.SwitchTo().Window();
driver.SwitchTo().Window(windowName: "Janela Principal");
driver.Navigate().GoToUrl("https://web.whatsapp.com");
driver.Manage().Window.Maximize();
// Espera 10 segundos
Thread.Sleep(60000);




// Mandar mensagem teste para um destinatário qualquer
// Esperar o e-mail chegar para enviar a mensagem de confirmação no WA 
//  "Bom dia/Boa tarde, (assunto do e-mail) foi enviado para seu e-mail ✉️"




// foreach (var contato in contatos)
// {
//     var caixaTextoPesquisa = driver.FindElement(OpenQA.Selenium.By.XPath($"//div[@title='Caixa de texto de pesquisa']"));
//     if (caixaTextoPesquisa is null) return;
//     caixaTextoPesquisa.SendKeys(contato);
//     Thread.Sleep(1000);
//     caixaTextoPesquisa.SendKeys(Keys.Enter);

//     var elementoPesquisa = driver.FindElement(OpenQA.Selenium.By.XPath($"//div[@data-testid='cell-frame-container']"));
//     elementoPesquisa.Click();
//     Thread.Sleep(1000);

//     var chatMensagem = driver.FindElement(OpenQA.Selenium.By.XPath("//div[@title='Mensagem']"));
//     chatMensagem.SendKeys("Bom dia!");
//     Thread.Sleep(1000);

//     var botaoEnviar = driver.FindElement(OpenQA.Selenium.By.XPath("//span[@data-testid='send']"));
//     botaoEnviar.Click();
// }

























































// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;

// var contatos = new List<string>(){
//     "Rascunho ~"
// };

// var applicationPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
// string drivePath = applicationPath + @"\ChromeDriver\";
// var driver = new ChromeDriver(drivePath);
// driver.Navigate().GoToUrl("https://web.whatsapp.com");
// driver.Manage().Window.Maximize();
// // Espera 10 segundos
// Thread.Sleep(60000);

// foreach (var contato in contatos)
// {
//     var caixaTextoPesquisa = driver.FindElement(OpenQA.Selenium.By.XPath($"//div[@title='Caixa de texto de pesquisa']"));
//     if (caixaTextoPesquisa is null) return;
//     caixaTextoPesquisa.SendKeys(contato);
//     Thread.Sleep(1000);
//     caixaTextoPesquisa.SendKeys(Keys.Enter);

//     var elementoPesquisa = driver.FindElement(OpenQA.Selenium.By.XPath($"//div[@data-testid='cell-frame-container']"));
//     elementoPesquisa.Click();
//     Thread.Sleep(1000);

//     var chatMensagem = driver.FindElement(OpenQA.Selenium.By.XPath("//div[@title='Mensagem']"));
//     chatMensagem.SendKeys("Bom dia!");
//     Thread.Sleep(1000);

//     var botaoEnviar = driver.FindElement(OpenQA.Selenium.By.XPath("//span[@data-testid='send']"));
//     botaoEnviar.Click();
// }