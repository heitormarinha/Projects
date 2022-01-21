//This Program does a DNS resolver, a ports scans and Denieal of service

#include <stdio.h>//uses to get input.
#include <netdb.h>//uses to work with socket.
#include <arpa/inet.h> // uses to work with InetNtoa method;
#include <sys/socket.h>// uses to work with socket.


// Rosolves DNS.
void DNSResolver(int argc, char *Argv[])
{
    struct hostent *targetDomain = gethostbyname(Argv[1]);
    printf("IP: %s\n", inet_ntoa(*((struct in_addr *)targetDomain->h_addr)));
}

//Port Scan.
void PortScan(int Argc, char *Argv[])
{
    int mySocket;
    int connectMySocket;
    char *destination = Argv[1];
    int port;
    
    struct sockaddr_in targetSocket;

    for (port=0;port<65535;port++)
    {
        mySocket = socket(AF_INET,SOCK_STREAM,0);
        targetSocket.sin_family = AF_INET;
        targetSocket.sin_port = htons(port);
        targetSocket.sin_addr.s_addr = inet_addr(destination);

        connectMySocket = connect(mySocket, (struct sockaddr *)&targetSocket, sizeof targetSocket);

        if(connectMySocket)
        {
            printf("The port %d is opened.\n",port);
            close(mySocket);
            close(connectMySocket);
        }
        else
        {
            close(mySocket);
            close(connectMySocket);
        }
    }
}