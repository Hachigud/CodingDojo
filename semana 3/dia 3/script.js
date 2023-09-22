function aumentarScore(elemento){

    let score = elemento.closest('.equipos').querySelector('.score');
    let totalScore = score.innerText;
    totalScore++;
    score.innerText = totalScore;
}

function subscribir(elemento){
    const sub = document.getElementById("card-sub");
    sub.remove();
}



window.onload = (event) => {
    setTimeout(function() {
        let pirates = document.getElementById("scorePirates").textContent;
        let ninjas = document.getElementById("scoreNinjas").textContent;
        if(pirates > ninjas){
            alert('The piras have won with ' + pirates +' goals');
        }
        else if(pirates < ninjas){
            alert('The ninjas have won with ' + ninjas +' goals');
        }else{
            alert('the teams tied');
        }

        
      }, 13000);
  };



