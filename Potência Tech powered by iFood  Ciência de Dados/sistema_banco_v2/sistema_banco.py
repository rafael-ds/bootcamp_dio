# Projeto proposto pelo bootcamp Dio.me Potência Tech powered by iFood | Ciência de Dados
# Objetivo é realizar um sistema bancario que simule as principais realizações como:
# Depositar - Sacar e Visualizar extratos
# Na resolução do desafio foi usado o funções no desenvolvimento do projeto.

num_conta = 0
saldo_conta = 0

extrato_depositos = []
extrato_saques = []


lista_clientes = {}


def banner(texto):
    print('\n')
    print('='*50)
    print(f'{texto}')
    print('='*50)
    # print('\n')
    

banner(' Desafio de projeto - - Sistema Bancário ')

def conta():
    global num_conta
    num_conta += 1

    return num_conta


def dados_cliente(nome, nasc, cpf, logradoro, bairro, cidade, uf, conta):
    novo_cliente = {
        'nome': nome,
        'nasc': nasc,
        'cpf': cpf,
        'endereco': {
            'logradoro': logradoro,
            'bairro': bairro,
            'cidade': cidade,
            'UF': uf
        },
        'conta':conta
    }
    
    return novo_cliente


def cadastrar_cliente():

    print('-'*100)

    nome = input('Infomer o seu nome completo: ')
    nasc = input('Infomer o sua data de nascimento : ')
    cpf = input('Infomer o seu CPF: ')
    logradoudo = input('Infomer o logradouro: ')
    bairro = input('Infomer o bairro: ')
    cidade = input('Infomer a cidade: ')
    uf = input('Infomer a UF: ')

    print('-'*100)

    novo_cadastro = dados_cliente(nome, nasc, cpf, logradoudo, bairro, cidade, uf, conta())

    lista_clientes[nome.upper()] = novo_cadastro

    menu_principal()


def login():

    if not lista_clientes:
        print('Nenhum cadastro realizado')
        print('Cadastre um usuario para continuar:\n')

        cadastrar_cliente()
        print('Clinte cadastrado com sucesso!\n')

        login()

    else:
        user = str(input('Informe seu usuario: '))
        cpf = str(input('Informe seu cpf:'))

        for i in lista_clientes.values():
            if i['nome'] == user and i['cpf'] == cpf:
                print(f'Seja bem vindo(a) - {i["nome"]}')

                menu({i["nome"]}, {i["conta"]})
        else:
            print('Senha ou usuário incorreto\n')
            login()


def sacar_valor():
    global saldo_conta

    print('sacar')

    print(' Informe o valor que deseja sacar: ')
    valor_saque = float(input())

    confirmar = input(f' Valor a ser depositado é de R${valor_saque} Pressione:\n [S] para confirmar o deposito\n [N] para cancelar o deposito \n')
    
    if confirmar == 's':

        if saldo_conta > valor_saque:
            saque = saldo_conta - valor_saque
            saldo_conta = saque

            extrato_saques.append(valor_saque)

        else:
            print(' Saldo insuficiente! ')
            print(f' Saldo atual R$ {conta}')

    elif confirmar == 'n':
        print(' Saque cancelado...\n')
    else:
        print(' Porfavor informe um opção valida\n')

''
def depositar_valor():
    global saldo_conta # Foi necessario para que ouvesse conexão com o a variavel conta do escopo global

    banner(' Depositar ')

    print(" Informe o valor a ser depositado:\n ")

    valor_deposito = float(input())

    confirmar = input(f' Valor para depósito é de R${valor_deposito} Pressione:\n [S] para confirmar o deposito\n [N] para cancelar o deposito \n')
    
    if confirmar == 's':

        saldo_conta += valor_deposito
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
   
    return f' Saldo em conta R$ {saldo_conta}'

def menu_principal():
    print(' [1] - Acessar sua conta')
    print(' [2] - Cria uma nova conta')
    print(' [3] - lista usuarios')
    print(' [4] - Sair')

    opcao = input()

    if opcao == '1':
        login()

    elif opcao == '2':
        cadastrar_cliente()

    elif opcao == '3':
        for i in lista_clientes:
            print(i)
        menu_principal()

    elif opcao == '4':
        exit()

    else:
        print('Informe uma opção valida')

# Função menu
# Parametro para mostra o nome do usuario toda vez que mostra o menu.
def menu(usuario_logado, conta):
    while True:

        banner(f' *--MENU--*\n Usuário: {usuario_logado} - Agencia: 00123 - Conta: {conta}')

        print('Informe a operação desejada:\n')

        print(' [1] - Sacar')
        print(' [2] - Depositar')
        print(' [3] - Extrato')
        print(' [4] - sair')

        opcao = input()

        if opcao == '1':
            sacar_valor()

        elif opcao == '2':
            depositar_valor()

        elif opcao == '3':
            print(extrato_bancario())
        
        elif opcao == '4':
            menu_principal()

        else:
            print('Favor digitar um opção válida\n')



menu_principal()



