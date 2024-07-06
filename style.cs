:root {
    --primary-color: red;
    --secondary-color: black;
    --text-color: white;
    --font-family: 'Netflix Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif;
}

* {
    box-sizing: border-box;
    font-family: var(--font-family);
}

.button-color,
.red-button {
    background-color: var(--primary-color);
    color: var(--text-color);
}

.top-image {
    height: 750px;
    width: 100%;
    background-image: linear-gradient(to top, rgba(10, 10, 10, 0.7), rgba(10, 10, 10, 0.7)), url('https://assets.nflxext.com/ffe/siteui/vlv3/c0a32732-b033-43b3-be2a-8fee037a6146/2fe6e3c0-5613-4625-a0c1-3d605effd10b/IN-en-20210607-popsignuptwoweeks-perspective_alpha_website_small.jpg');
}

.top-white-text {
    color: var(--text-color);
    height: 1000px;
}

.subscribe-box {
    background-color: var(--primary-color);
}

.block {
    height: 500px;
    position: relative;
    top: 25%;
}

h1 {
    font-size: 2rem;
    font-weight: 600;
}

.back-black {
    background-color: var(--secondary-color);
    color: var(--text-color);
    height: 400px;
}

.back-lg-black {
    background-color: var(--secondary-color);
    color: var(--text-color);
    height: 600px;
}

.back-lg-black-2 {
    background-color: var(--secondary-color);
    color: var(--text-color);
    height: 750px;
}

.accordion-flush {
    background-color: var(--secondary-color);
    color: var(--text-color);
}
