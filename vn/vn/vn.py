import socket as soc
import json


## Create TCP socket
sock = soc.socket(soc.AF_INET, soc.SOCK_STREAM)
server_address = ('api.vndb.org', 19534)

## Try to connect
try:
    sock.connect(server_address)
    #print('Connected to socket')
except soc.error as err:
    print('Error connecting to socket: %s' %(err))

## Login

client_var = {"protocol":1,"client":"test","clientver":0.1}
cmd = 'login ' + json.dumps(client_var) + '\x04'

def send_cmd(cmd, params=''):
    final_cmd = cmd + ' ' + params + '\x04'
    sock.sendall(final_cmd.encode('utf-8'))

def receive_data(buffersize = 4096):
    data = ''.encode()
    finished = False
    while not finished:
        data += sock.recv(buffersize)
        if '\x04'.encode('utf-8') in data:
            finished = True
    return data.decode('utf-8')

def login():
    try:
        send_cmd('login', json.dumps(client_var))
        if 'ok' in receive_data():
            #print('authentication sucessful!')
            return 1
            pass
        else:
            print('authentication NOT sucessful')
            return 0
    except:
        print('error login') ## TODO: proper error message

## Get command
def get(type, flags, filters):
    params = type + ' ' + flags + ' ' + filters
    send_cmd('get', params)


if '__name__' == '__main__':
   try:
        send_cmd('login', json.dumps(client_var))
        if 'ok' in receive_data():
            print('authentication sucessful!')
   
        send_cmd('dbstats')
        print(receive_data())

        send_cmd('get', 'vn stats,anime (id = 17)')
        print(receive_data())

   except soc.error as err:
        print('Error: %s' %(err))







