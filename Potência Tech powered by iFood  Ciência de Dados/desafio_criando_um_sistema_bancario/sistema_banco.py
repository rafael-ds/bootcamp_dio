conta = []

# Função banner que tem como objetivo somente informar em que area o úsuario se encontra
def banner(texto):
    print('\n')
    print('='*50)
    print(f'{texto}')
    print('='*50)
    # print('\n')
    

banner(' Desafio de projeto - - Sistema Bancário ')


def sacar_valor():
    print('sacar')

# Função que tem como objetivo depositar um valor na lista Conta[]
def depositar_valor():

    banner(' Depósitar ')

    print(" Informe o valor a ser depositado:\n ")

    valor_deposito = int(input())

    confirmar = input(f' Valor para depósito é de R${valor_deposito} Pressione:\n [S] para comfirmar o deposito\n [N] para cancelar o deposito \n')

    if confirmar == 's':
        conta.append(valor_deposito)
        print(f'\n R${valor_deposito} depósitado com sucesso!')
        # Reesibir extrato apos o processo
        

    elif confirmar == 'n':
        print('Deposito cancelado\n')
    else:
        print('Porfavor informe um opção valida\n')


def extrato_bancario():
    banner('Extrato')

    print('-'*25, 'Depósitos', '-'*25)

    for i in conta:
        print(f' R$ {i}')

    print('-'*60)


    saldo_em_conta = sum(conta)    
    return f' Saldo em conta R$ {saldo_em_conta}'


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
    #    extrato_bancario()
        print(extrato_bancario())

    elif entrada == sair:
        break
    else:
        print('Favor digitar um opção valida\n')



