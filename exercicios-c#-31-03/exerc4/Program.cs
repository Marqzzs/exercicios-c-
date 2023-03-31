// 4) Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
// "Telefonou para a vítima?"
// "Esteve no local do crime?"
// "Mora perto da vítima?"
// "Devia para a vítima?"
// "Já trabalhou com a vítima?"
// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

// using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;

        Console.WriteLine("Responda 'sim' ou 'nao' para as seguintes perguntas:");

        Console.Write("Telefonou para a vítima? ");
        if (Console.ReadLine().ToLower() == "sim")
        {
            count++;
        }

        Console.Write("Esteve no local do crime? ");
        if (Console.ReadLine().ToLower() == "sim")
        {
            count++;
        }

        Console.Write("Mora perto da vítima? ");
        if (Console.ReadLine().ToLower() == "sim")
        {
            count++;
        }

        Console.Write("Devia para a vítima? ");
        if (Console.ReadLine().ToLower() == "sim")
        {
            count++;
        }

        Console.Write("Já trabalhou com a vítima? ");
        if (Console.ReadLine().ToLower() == "sim")
        {
            count++;
        }

        if (count == 5)
        {
            Console.WriteLine("Culpado");
            Console.WriteLine($"Você é o mordomo");
            Console.WriteLine($@" 
            ######..  ..####                                                                                                                            
mm####++    ..  ####                                                                                                                        
  ######            ####                                                                                                                    
  MM####                ####                                                                                                          MM##@@
    ####                  ..####                                                                                                  ####    ..
      ##--                    ..##..                                                                                        ####  ....      
      ####..                    ..--##                                                                                  ##MM....            
        ##..                          ####                                                                        ####..    ..              
          ##                              ##                                                                  ####..                        
          MM--                            ..##::                                                        @@##....                            
            ##..                              ::##                                                  ####                                    
              ##..                            ..  ################MM::..............::mm@@########..                                        
                ##..                                                                  ..                                                    
                  ##..                                                                                                                  ....
                    @@                                                                                                                ....##
                    ++++..                                                                                                          ....##  
                      @@--                                                                                                            ##    
                        ##....                                                                                                    ..##      
                          ##....##                                                                                              ::##        
                            ####..                                                                                          ..##..          
                            ##..                                                                                  MM##  ..####              
                            mm                                                                                      ++##mm                  
                          ##                                                                                          ##                    
                          ##                ....                                            ....  ..                ..MM                    
                          ++..            ..mm@@..                                        ....##::                      ##                  
                        MM..            ..@@--####++..                                    ##  ######....                ##                  
                        ##..            ##    ######                                      ##    ######                ..::                  
                        ##            ..####@@######                                    mm##--########                  ..##                
                        ##            ..############                                    ..############..                  ##                
                        ..            ....########MM..                                    ##########                    ..MM                
                      @@                    ####..                                          ..##MM..                        MM              
                      ##                                            ..                        ..                            ##              
                      ##..                                    ########..                                                    ##              
                      ##..                                  ..  ####..                                    ..  ..          ..MM              
                      ++++++mm..                                                                          --++++....        ..::            
                    @@++++++++mm++                                                                    ..mm++++++mm++..      ..##            
                    ##++++++++++++..                                                                  ++++++++++++++          ##            
                    ##++++++++++++++                                                                --++++++++++++++mm        ++            
                    mm++++++++++++++                        ....    ..........                    ..++++++++++++++++++..      ..##          
                  ##++++++++++++++++                        ######----------##                      ::++++++++++++++++          ##          
                  ##++++++++++++++..                        ##@@--------------++                    ..++++++++++++mm....        ##          
                  ##..++mm++++mm                          ..##::--------------##                      ..mm++mm++mm++              --        
                  ##......--....                          ..MM----------------##                          ++++++                ..##        
                  ::    ..  ..                              ------------------##                                                  ##        
                    @@..                                  ..------------------..                                                  ::        
                    ##..                                    ..--------------##                                                      ##      
                    MM                                          ##------mm--                                                      ..##      
                      ##..                                    ..    ..  ......                                                      ##      
                      ##..                                                                                                                  
            ");

        }
        else if (count >= 3)
        {
            Console.WriteLine("Cúmplice");
        }
        else if (count >= 2)
        {
            Console.WriteLine("Suspeita");
        }
        else
        {
            Console.WriteLine("Inocente");
        }
    }
}
