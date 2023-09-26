function mover(e){
    if (e.keyCode == 65) { // LEFT
        pacman.removeAttribute('class');
        if (world[ninjaman.y][ninjaman.x - 1] != 1) {
            ninjaman.x--;
            pacman.classList.add('left');

        

            if (world[ninjaman.y][ninjaman.x] == 2) {

                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;


            }

            if (world[ninjaman.y][ninjaman.x] == 3) {

                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }
        }




    }
    if (e.keyCode == 68) { // RIGHT
        pacman.removeAttribute('class');
        if (world[ninjaman.y][ninjaman.x + 1] != 1) {
            ninjaman.x++;

 
            
            
           
            if (world[ninjaman.y][ninjaman.x] == 2) {
                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;
            }
            if (world[ninjaman.y][ninjaman.x] == 3) {
                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }
        }



    }
    if (e.keyCode == 83) { // DOWN
        pacman.removeAttribute('class');
        if (world[ninjaman.y + 1][ninjaman.x] != 1) {
            ninjaman.y++;
            pacman.classList.add('down');

          


            if (world[ninjaman.y][ninjaman.x] == 2) {
                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;

            }
            if (world[ninjaman.y][ninjaman.x] == 3) {
                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }
        }



    }
    if (e.keyCode == 87) { // top
        pacman.removeAttribute('class');
        if (world[ninjaman.y - 1][ninjaman.x] != 1) {
           
            ninjaman.y--;
            pacman.classList.add('up');

          
            if (world[ninjaman.y][ninjaman.x] == 2) {

                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;

            }

            if (world[ninjaman.y][ninjaman.x] == 3) {

                world[ninjaman.y][ninjaman.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }

        }


    }




    if (e.keyCode == 37 ) { // LEFT
        pacman2.removeAttribute('class');
        if (world[ninjaman2.y][ninjaman2.x - 1] != 1) {
            ninjaman2.x--;
            pacman2.classList.add('left');

        

            if (world[ninjaman2.y][ninjaman2.x] == 2) {

                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;


            }

            if (world[ninjaman2.y][ninjaman2.x] == 3) {

                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }
        }




    }
    if (e.keyCode == 39 ) { // RIGHT
        pacman2.removeAttribute('class');
        if (world[ninjaman2.y][ninjaman2.x + 1] != 1) {
            ninjaman2.x++;

 
            
            
           
            if (world[ninjaman2.y][ninjaman2.x] == 2) {
                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;
            }
            if (world[ninjaman2.y][ninjaman2.x] == 3) {
                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman2.puntaje += 10;

            }
        }



    }
    if (e.keyCode == 40 ) { // DOWN
        pacman2.removeAttribute('class');
        if (world[ninjaman2.y + 1][ninjaman2.x] != 1) {
            ninjaman2.y++;
            pacman2.classList.add('down');

          


            if (world[ninjaman2.y][ninjaman2.x] == 2) {
                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;

            }
            if (world[ninjaman2.y][ninjaman2.x] == 3) {
                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }
        }



    }
    if (e.keyCode == 38 ) { // top
        pacman2.removeAttribute('class');
        if (world[ninjaman2.y - 1][ninjaman2.x] != 1) {
           
            ninjaman2.y--;
            pacman2.classList.add('up');

          
            if (world[ninjaman2.y][ninjaman2.x] == 2) {

                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 50;

            }

            if (world[ninjaman2.y][ninjaman2.x] == 3) {

                world[ninjaman2.y][ninjaman2.x] = 0;
                drawWorld();
                ninjaman.puntaje += 10;

            }

        }


    }


  

        if(e.keyCode == 68 || e.keyCode == 83 || e.keyCode == 87 || e.keyCode == 65){
        if (ninjaman.x < red.x) {
    
            if (world[red.y][red.x - 1] != 1) {
                red.x--;
            }
        }
        if (ninjaman.x > red.x) {
            if (world[red.y][red.x + 1] != 1) {
                red.x++;
            }
        }
    
        if (ninjaman.y < red.y) {
            if (world[red.y - 1][red.x] != 1) {
                red.y--;
            }
        }
    
        if (ninjaman.y > red.y) {
            if (world[red.y + 1][red.x] != 1) {
                red.y++;
            }
        }
    
    
        if (ninjaman.x < bluey.x) {
    
            if (world[bluey.y][bluey.x - 1] != 1) {
                bluey.x--;
            }
        }
        if (ninjaman.x > bluey.x) {
            if (world[bluey.y][bluey.x + 1] != 1) {
                bluey.x++;
            }
        }
        if (ninjaman.y < bluey.y) {
            if (world[bluey.y - 1][bluey.x] != 1) {
                bluey.y--;
            }
        }
        if (ninjaman.y > bluey.y) {
            if (world[bluey.y + 1][bluey.x] != 1) {
                bluey.y++;
            }
        }
    
        if (ninjaman.x < pinky.x) {
    
            if (world[pinky.y][pinky.x - 1] != 1) {
                pinky.x--;
            }
        }
        if (ninjaman.x > pinky.x) {
            if (world[pinky.y][pinky.x + 1] != 1) {
                pinky.x++;
            }
        }
        if (ninjaman.y < pinky.y) {
            if (world[pinky.y - 1][pinky.x] != 1) {
                pinky.y--;
            }
        }
        if (ninjaman.y > pinky.y) {
            if (world[pinky.y + 1][pinky.x] != 1) {
                pinky.y++;
            }
        }
    
        if (ninjaman.x < pumpky.x) {
    
            if (world[pumpky.y][pumpky.x - 1] != 1) {
                pumpky.x--;
            }
        }
        if (ninjaman.x > pumpky.x) {
            if (world[pumpky.y][pumpky.x + 1] != 1) {
                pumpky.x++;
            }
        }
        if (ninjaman.y < pumpky.y) {
            if (world[pumpky.y - 1][pumpky.x] != 1) {
                pumpky.y--;
            }
        }
        if (ninjaman.y > pumpky.y) {
            if (world[pumpky.y + 1][pumpky.x] != 1) {
                pumpky.y++;
            }
        }
    
    }
    
    
    
    
        if (e.keyCode == 40 || e.keyCode == 37 || e.keyCode == 38 || e.keyCode == 39) {
            if (ninjaman2.x < red.x) {
    
                if (world[red.y][red.x - 1] != 1) {
                    red.x--;
                }
            }
            if (ninjaman2.x > red.x) {
                if (world[red.y][red.x + 1] != 1) {
                    red.x++;
                }
            }
    
            if (ninjaman2.y < red.y) {
                if (world[red.y - 1][red.x] != 1) {
                    red.y--;
                }
            }
    
            if (ninjaman2.y > red.y) {
                if (world[red.y + 1][red.x] != 1) {
                    red.y++;
                }
            }
    
    
            if (ninjaman2.x < bluey.x) {
    
                if (world[bluey.y][bluey.x - 1] != 1) {
                    bluey.x--;
                }
            }
            if (ninjaman2.x > bluey.x) {
                if (world[bluey.y][bluey.x + 1] != 1) {
                    bluey.x++;
                }
            }
            if (ninjaman2.y < bluey.y) {
                if (world[bluey.y - 1][bluey.x] != 1) {
                    bluey.y--;
                }
            }
            if (ninjaman2.y > bluey.y) {
                if (world[bluey.y + 1][bluey.x] != 1) {
                    bluey.y++;
                }
            }
    
            if (ninjaman2.x < pinky.x) {
    
                if (world[pinky.y][pinky.x - 1] != 1) {
                    pinky.x--;
                }
            }
            if (ninjaman2.x > pinky.x) {
                if (world[pinky.y][pinky.x + 1] != 1) {
                    pinky.x++;
                }
            }
            if (ninjaman2.y < pinky.y) {
                if (world[pinky.y - 1][pinky.x] != 1) {
                    pinky.y--;
                }
            }
            if (ninjaman2.y > pinky.y) {
                if (world[pinky.y + 1][pinky.x] != 1) {
                    pinky.y++;
                }
            }
    
            if (ninjaman2.x < pumpky.x) {
    
                if (world[pumpky.y][pumpky.x - 1] != 1) {
                    pumpky.x--;
                }
            }
            if (ninjaman2.x > pumpky.x) {
                if (world[pumpky.y][pumpky.x + 1] != 1) {
                    pumpky.x++;
                }
            }
            if (ninjaman2.y < pumpky.y) {
                if (world[pumpky.y - 1][pumpky.x] != 1) {
                    pumpky.y--;
                }
            }
            if (ninjaman2.y > pumpky.y) {
                if (world[pumpky.y + 1][pumpky.x] != 1) {
                    pumpky.y++;
                }
            }
    
        }
    



}


    var worldDict = {
        0: 'blank',
        1: 'wall',
        2: 'sushi',
        3: 'nigiri'
        
    }
   
    var world = [
        [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],  
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],    // creamos nuestro "mapa" inicial
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],  // junto con la posiciond e los enemigos inicial
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]
    ];
    function generateWorld(){      

        var ramdom = 0;
        for (var i =  0; i< world.length; i++){
            for(j = 0; j<world[i].length; j++){
                var valor = Math.ceil(Math.random(2,3)*3); 
            
             world[i][j] = valor;
            }
           
        }

        for(var h = 0; h <  13; h++){
            world[0][h] = 1;
            world[17][h] = 1;     
        }                                   // forzamos los limites del mapa
        for(var h = 0; h <  18; h++){
            world[h][0] = 1;
            world[h][13] = 1;
        }
        world[1][1] = 0;
        world[1][12] = 2;
        world[16][12] = 2;
        world[10][7] = 2;
        world[16][1] = 2;
        world[1][2] = 2;  //forzamos que el inicio del ninja y de las calabazas siempre este vacio
        world[2][1] = 2;    // ya  su alrededor
        world[2][2] = 2;  // en algunos cazos igualmente se quedara atrapado
        world[6][6] = 0; 
        world[6][7] = 2; 
    }

    function drawWorld() {
        output = "";
        for (var row = 0; row < world.length; row++) {
            output += "<div class = 'row'> </div>";
            for (var x = 0; x < world[row].length; x++) {
                output += "<div class = '" + worldDict[world[row][x]] + " '> </div>";
            }

            output += "</div>";

        }
        document.getElementById("world").innerHTML =
            output;
    }



    generateWorld();
    drawWorld();

    var pacman = document.getElementById('ninjaman');
    var pacman2 = document.getElementById('ninjaman2');
    var ninjaman = {
        x: 1,
        y: 1,
        puntaje: 0,
        vidas: 3
    }

    var ninjaman2 = {
        x: 6,
        y: 6,
        puntaje: 0,
        vidas: 3
    }
    var bluey = {
        x: 12,
        y: 1
    }

    var pinky = {
        x: 12,
        y: 15
    }

    var pumpky = {
        x: 1,
        y: 16
    }

    var red = {
        x: 7,
        y: 16
    }

    

    function drawNinjaman() {
        document.getElementById("ninjaman").style.top = ninjaman.y * 40 + 'px';
        document.getElementById("ninjaman").style.left = ninjaman.x * 40 + 'px';
        document.getElementById("ninjaman2").style.top = ninjaman2.y * 40 + 'px';
        document.getElementById("ninjaman2").style.left = ninjaman2.x * 40 + 'px';
        document.getElementById("puntaje").innerHTML = ninjaman.puntaje;
        document.getElementById("vidas").innerHTML = ninjaman.vidas;
    }

    function drawbluey() {
        document.getElementById("bluey").style.top = bluey.y * 40 + 'px';
        document.getElementById("bluey").style.left = bluey.x * 40 + 'px';

    }

    function drawpinky() {
        document.getElementById("pinky").style.top = pinky.y * 40 + 'px';
        document.getElementById("pinky").style.left = pinky.x * 40 + 'px';

    }

    function drawpumpky() {
        document.getElementById("pumpky").style.top = pumpky.y * 40 + 'px';
        document.getElementById("pumpky").style.left = pumpky.x * 40 + 'px';

    }

    function drawred() {
        document.getElementById("red").style.top = red.y * 40 + 'px';
        document.getElementById("red").style.left = red.x * 40 + 'px';

    }

    drawNinjaman();
    drawbluey();
    drawpinky();
    drawpumpky();
    drawred();
    
   
    document.onkeydown = function (e) {  
        mover(e);
        
      




    if ((world[ninjaman.y][ninjaman.x] == world[bluey.y][bluey.x] || world[ninjaman.y][ninjaman.x] == world[pinky.y][pinky.x] || world[ninjaman.y][ninjaman.x] == world[pumpky.y][pumpky.x] || world[ninjaman.y][ninjaman.x] == world[red.y][red.x]) || (world[ninjaman2.y][ninjaman2.x] == world[bluey.y][bluey.x] || world[ninjaman2.y][ninjaman2.x] == world[pinky.y][pinky.x] || world[ninjaman2.y][ninjaman2.x] == world[pumpky.y][pumpky.x] || world[ninjaman2.y][ninjaman2.x] == world[red.y][red.x])) {
            ninjaman.vidas--;
            if (ninjaman.vidas < 0) {
            alert("Te has quedado sin vidas, el juego se reiniciara");
            location.reload();
        }else{
        alert("perdiste una vida se regenerara el mundo");
         generateWorld();
            drawWorld();
            ninjaman.x = 1;
            ninjaman.y = 1;
            ninjaman2.x = 6;
            ninjaman2.y = 6;
            bluey.x = 12;
            bluey.y = 1;
            pinky.x = 12;
            pinky.y = 16;
            pumpky.x = 1;
            pumpky.y = 16;
            red.x = 7;
            red.y = 16;
        }     
            
         
         
        }
        
        drawNinjaman();
        drawbluey();
        drawpinky();
        drawpumpky();
        drawred();
    }

