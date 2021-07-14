import addMoviePage from "./pages/addMovie.js";
import editMoviePage from "./pages/editMovie.js";
import homePage from "./pages/home.js";
import loginPage from "./pages/login.js";
import movieDetailsPage from "./pages/movieDetails.js";
import navBar from "./pages/navBar.js";
import registerPage from "./pages/register.js";


async function setup(){

    let appElement = document.getElementById()

    loginPage.initialize(document.getElementById('form-login'));
    registerPage.initialize(document.getElementById('form-sign-up'));
    homePage.initialize(document.getElementById('home-page'));
    navBar.initialize(document.getElementById(''));
    addMoviePage.initialize(document.getElementById('add-movie'));
    editMoviePage.initialize(document.getElementById('edit-movie'));
    movieDetailsPage.initialize(document.getElementById('movie-details'));



}