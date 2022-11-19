using ReadEmail;

var email = new Email(iMAP_HOST: "outlook.office365.com", iMAP_USER: "ribeiro12369@hotmail.com", iMAP_PASSWORD: ENV.PASSWORD);
await email.Connect();
var mesages = email.GetMessages();

Console.ReadLine();