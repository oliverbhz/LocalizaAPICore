# LocalizaAPICore

1.	Um cliente precisa de um sistema que seja capaz de decompor um número em todos os seus divisores, enumerando também aqueles que forem primos. Obs.: 
    Não é permitido o uso de bibliotecas prontas, se houver, que façam a decomposição. 
a.	Dado um número de entrada, o programa deve calcular todos os divisores que compõem o número. 
b.	Dado um número de entrada, o programa deve calcular todos os divisores primos que compõem o número

Exemplo: 
Entrada: 40 
Saída: Divisores: 1, 2, 4, 5, 8, 10, 20, 40 
       Divisores Primos: 2, 5 

2.	Já temos nossa funcionalidade principal. Contudo, você acaba de descobrir que essa funcionalidade vai ser usada em outros sistemas e, por isso, 
    é necessário que seja disponibilizada um serviço que forneça as informações. Fique atento a: 
a.	Performance 
b.	Escalabilidade 
c.	Disponibilidade 
d.	Resiliência 
e.	Robustez 

#######################################################################################################################################################################
# Teste da API

Postman: 
    Method: GET
    URL: https://localhost:<port>/api/decomposenumber/<value>
