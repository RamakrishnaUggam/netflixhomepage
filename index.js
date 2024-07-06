function getStarted(em) {
    let email = document.getElementById(em).value;
    let flag1 = false, flag2 = false;
    
    console.log("started " + email);
    
    for (let z of email) {
        if (z === '@') {
            console.log("@ detected");
            flag1 = true;
        }
        
        if (z === '.') {
            console.log(". detected");
            flag2 = true;
        }
    }
    
    if (flag1 && flag2) {
        alert("Hola! This will take you to Login or Register Page.");
    } else {
        alert("Enter a valid email!");
    }
}

function signIn() {
    alert("This will take you to the SignIn Page!");
}
