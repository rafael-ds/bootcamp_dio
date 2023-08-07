
print('\n')
print('='*50)
print('Desafio de projeto - - Sistema Bancário')
print('='*50)
print('\n')


def sacar_valor():
    print('sacar')

def depositar_valor():
    print('depositar')

def extrato_bancario():
    print('extrato')


while True:
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



