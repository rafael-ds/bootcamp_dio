# Projeto proposto pelo bootcamp Dio.me Potência Tech poered by iFood | Ciência de Dados
# Objetivo é realizar um sistema bancario que simule as principais realizações como:
# Depositar - Sacar e Visualizar extratos
# Na resolução do desafio foi usado o funções no desenvolvimento do projeto.

conta = 0

extrato_depositos = []
extrato_saques = []


def banner(texto):
    print('\n')
    print('='*50)
    print(f'{texto}')
    print('='*50)
    # print('\n')
    

banner(' Desafio de projeto - - Sistema Bancário ')


def sacar_valor():
    global conta

    print('sacar')

    print(' Informe o valor que deseja sacar: ')
    valor_saque = float(input())

    confirmar = input(f' Valor a ser depositado é de R${valor_saque} Pressione:\n [S] para confirmar o deposito\n [N] para cancelar o deposito \n')
    
    if confirmar == 's':

        if conta > valor_saque:
            saque = conta - valor_saque
            conta = saque

            extrato_saques.append(valor_saque)

        else:
            print(' Saldo insuficiente! ')
            print(f' Saldo atual R$ {conta}')

    elif confirmar == 'n':
        print(' Saque cancelado...\n')
    else:
        print(' Porfavor informe um opção valida\n')


def depositar_valor():
    global conta # Foi necessario para que ouvesse conexão com o a variavel conta do escopo global

    banner(' Depositar ')

    print(" Informe o valor a ser depositado:\n ")

    valor_deposito = float(input())

    confirmar = input(f' Valor para depósito é de R${valor_deposito} Pressione:\n [S] para confirmar o deposito\n [N] para cancelar o deposito \n')
    
    if confirmar == 's':

        conta += valor_deposito
        extrato_depositos.append(valor_deposito)

        print(f'\n R${valor_deposito} depósitado com sucesso!')
        

    elif confirmar == 'n':
        print(' Deposito cancelado\n')
    else:
        print(' Porfavor informe um opção válida\n')


def extrato_bancario():
    banner('Extrato')

    print('-'*25, 'Depositos', '-'*25)

    for i in extrato_depositos:
        print(f' R$ {i}')

    print('-'*60)

    print('-'*25, 'Saques', '-'*25)

    for i in extrato_saques:
        print(f' R$ {i}')

    print('-'*60)
   
    return f' Saldo em conta R$ {conta}'


while True:

    banner(' Menu ')

    print('Informe a operação desejada:\n')

    print(' [1] - Sacar')
    print(' [2] - Depositar')
    print(' [3] - Extrato')
    print(' [4] - sair')

    sacar = '1'
    depositar = '2'
    extrato = '3'
    sair = '4'

    entrada = input()

    if entrada == sacar:
        sacar_valor()

    elif entrada == depositar:
        depositar_valor()

    elif entrada == extrato:
        print(extrato_bancario())

    elif entrada == sair:
        break
    else:
        print('Favor digitar um opção válida\n')



