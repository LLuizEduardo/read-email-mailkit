using ReadEmail;
using System.Threading;
using System;

Config config = new Config();
string[] cred = config.tratar();
var email = new Email(iMAP_HOST: "mail2-2016.aec.com.br", iMAP_USER: cred[0], iMAP_PASSWORD: cred[1]);

await email.Connect();
var mesages = email.GetMessages();

Console.ReadLine();