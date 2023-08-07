
# Função banner que tem como objetivo somente informar em que area o úsuario se encontra
def banner(texto):
    print('\n')
    print('='*50)
    print(f'{texto}')
    print('='*50)
    print('\n')

def banner_extrato(valor):
    print('\n')
    print('='*50)
    print(f'Saldo em conta R${valor}')
    print('='*50)
    print('\n')



banner(' Desafio de projeto - - Sistema Bancário ')

conta = []

def sacar_valor():
    print('sacar')

def depositar_valor():

    banner(' Depósitar ')

    print(" Informe o valor a ser depositado:\n ")

    valor_deposito = input(' ')

    confirmar = input(f' Valor para depósito é de R${valor_deposito}\n Pressione\n [S] para comfirmar o deposito\n [N] para cancelar o deposito \n')

    if confirmar == 's':
        conta.append(valor_deposito)
        print(f'\n R${valor_deposito} depósitado com sucesso!\n')

        for i in conta:
            print(f'Slado em conta R${conta}')

    elif confirmar == 'n':
        print('Deposito cancelado\n')
    else:
        print('Porfavor informe um opção valida\n')




def extrato_bancario():
    print('extrato')


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
       extrato_bancario()

    elif entrada == sair:
        break
    else:
        print('Favor digitar um opção valida\n')



