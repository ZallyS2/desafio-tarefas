using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("ConexaoPadrao"),
        new MySqlServerVersion(new Version(8, 0, 43))
    ));

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
                    <html lang='pt-BR'>
                    <head>
                        <meta charset='UTF-8'>
                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                        <title>Documentação da API</title>
                        <style>
                            body {
                                font-family: Arial, sans-serif;
                                background: linear-gradient(135deg, #4f46e5, #9333ea);
                                color: white;
                                text-align: center;
                                padding: 50px;
                            }
                            h1 {
                                font-size: 2.5em;
                                margin-bottom: 20px;
                            }
                            p {
                                font-size: 1.2em;
                                margin-bottom: 30px;
                            }
                            .bottom {
                                background-color: white;
                                color: #4f46e5;
                                padding: 15px 30px;
                                border-radius: 8px;
                                text-decoration: none;
                                font-weight: bold;
                                transition: background 0.3s, color 0.3s;
                            }
                            .bottom:hover {
                                background-color: #4f46e5;
                                color: white;
                                border: 2px solid white;
                            }
                            .rodape {
                                margin-top: 100px;
                                bottom: 0%;
                                position: relative;
                                width: 100%;
                            }
                        </style>
                    </head>
                    <body>
                        <h1>Bem-vindo à API</h1>
                        <p>Explore e teste os endpoints da API usando nossa documentação interativa.</p>
                        <a href='/swagger' class='bottom'>📄 Abrir Swagger</a>
                        <br />
                        
                        <div class ='rodape'>
                            <hr />
                            <p align='center'>Feito com 💜 por Laila Zappiello</p>
                            <a href='https://www.instagram.com/zzappiello.o/'><img src='https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white' /></a>
                            <a href='mailto:lailazappiello90@gmail.com'><img src='https://img.shields.io/badge/Gmail-333333?style=for-the-badge&logo=gmail&logoColor=red' /></a>
                            <a href='https://wa.me/5511981642627'><img src='https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white' /></a>
                            <a href='https://www.linkedin.com/in/laila-zappiello/' target='_blank'><img src='https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white' target='_blank'></a> 
                            <br><br>
                            <p align='center'>
                                🌌 <strong>'Em um lugar escuro estamos nós. E mais conhecimento ilumina nosso caminho.'</strong> – Star Wars
                            </p>
                            <p align='center'>
                                <img src='https://github.com/zallih/Images/blob/main/Jedi%20grogu%F0%9F%92%9A.jpeg?raw=true' width='250px' />
                            </p>

                        </div>
                    </body>
                    </html>
                    ", "text/html"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
