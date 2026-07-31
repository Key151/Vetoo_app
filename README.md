# Vetoo

## Descrição da Proposta:
Vetoo é um jogo de tabuleiro inspirado no Tabu, desenvolvido para ser jogado entre duas equipes. O objetivo é fazer com que seus companheiros descubram a palavra principal exibida na carta, utilizando dicas e descrições, sem mencionar nenhuma das palavras proibidas associadas a ela.
A cada rodada, um jogador assume o papel de narrador e tenta ajudar sua equipe a acertar a palavra principal dentro do tempo disponível. Caso utilize uma das palavras proibidas durante a explicação, a jogada é considerada inválida. Quando a equipe acerta a palavra, ganha um ponto e uma nova carta é apresentada.
O jogo continua alternando entre as equipes até o término da partida ou até atingir a pontuação definida. Ao final, a equipe com o maior número de pontos é declarada vencedora.
O principal objetivo do Vetoo é proporcionar diversão, estimular a criatividade dos jogadores e incentivar a comunicação e o trabalho em equipe de forma dinâmica e descontraída.

## 📥 Download  
[![Vetoo APK](https://shields.io)](https://github.com/Key151/Vetoo/releases/download/v1.0.0/Vetoo.apk)  

## Explicação mais detalhada das regras (vídeo de 2min):
https://www.youtube.com/watch?v=l-3mPvP02Ew

## Mecânicas Principais:  
• Cadastro do nome dos jogadores.  
• Sistema de cartas carregadas através de arquivo JSON.  
• Embaralhamento aleatório das cartas a cada partida.  
• Exibição da palavra principal e das palavras proibidas.  
• Sistema de pontuação para as equipes.  
• Controle de música e volume.  
• Interface otimizada para dispositivos móveis.  
• Navegação entre telas do jogo.

## Tecnologias Utilizadas:  
• Unity 6  
• Linguagem C#  
• JSON para armazenamento das cartas  
• JSON Minifier – No site da Code Beautify  
• Gemini e ChatGPT – para criação de imagem e auxiliar no código  
• Git (caso utilizado para controle de versão)  

## Explicação dos Requisitos Implementados:  
### Sistema de Dados
As cartas do jogo foram armazenadas em formato JSON, permitindo fácil manutenção e expansão do banco de palavras. Durante a inicialização do jogo, os dados são carregados e convertidos para objetos C#.

### Sistema de Embaralhamento
Foi implementado um algoritmo de embaralhamento para garantir que as cartas apareçam em ordem aleatória a cada partida.

### Interface Gráfica
A interface foi desenvolvida utilizando Canvas e componentes como TextMeshPro, Slider e Image, proporcionando boa visualização em diferentes resoluções de tela.

### Sistema de Áudio
Foi implementado um sistema de música de fundo (BGM), além de controle de volume através de Slider.

### Sistema de Pontuação
Os pontos são contabilizados ao longo da partida e apresentados aos jogadores para determinar o vencedor ao final do jogo.

### Persistência de Dados
Os nomes dos jogadores e configurações necessárias são mantidos durante a execução do jogo, garantindo continuidade da experiência entre as telas.
