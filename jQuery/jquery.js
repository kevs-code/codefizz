//script tag
//index.html
<!DOCTYPE html>
<html>

<head>
  <title>Sole Shoes</title>
  <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,700' rel='stylesheet'>
  <link href='https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700' rel='stylesheet'>
  <link rel='stylesheet' type='text/css' href='css/styles.css'>
</head>

<body>

  <!-- Navigation -->
  <nav>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>
        <span class='menu-button'>Menu</span>
        <span class='login-button'>Login</span>
      </div>
    </div>
  </nav>

  <!-- Nav Menu -->
  <div class='nav-menu hide'>
    <div class='container'>
      <ul>
        <li>Shoes</li>
        <li>Women's Shoes</li>
        <li>Men's Shoes</li>
        <li>Shoe Accessories</li>
        <li>Wholesale</li>
      </ul>
      <ul>
        <li>Contact</li>
        <li>Twitter</li>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>Email</li>
      </ul>
    </div>
  </div>

  <!-- Login Form -->
  <div class='login-form'>
    <div class='container'>
      <form>
        <h4>Username</h4>
        <input class='username' />
        <h4>Password</h4>
        <input type='password' />
        <input class='sign-in-button' type='submit' value='Sign In' />
      </form>
    </div>
  </div>

  <!-- Product Cards -->
  <div class='container'>
    <div class='product-card'>
      <div class='product-photo sole-air-ii'></div>
      <div class='product-details'>
        <h4>Sole Air II</h4>
        <div>
          <p>$35</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The ultimate in style and comfort, the Sole Air II's are great for walking and casual wearing.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>8</li>
            <li>9</li>
            <li>10</li>
            <li>11</li>
            <li>12</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo tidal-x'></div>
      <div class='product-details'>
        <h4>Tidal X</h4>
        <div>
          <p>$40</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The Tidal X's signature rubber midsole make this the perfect running shoe. With a soft mesh upper, and synthetic polymer outsole, these shoes really fly.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>6</li>
            <li>7</li>
            <li>10</li>
            <li>12</li>
            <li>13</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>

    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo dark-sole-original'></div>
      <div class='product-details'>
        <h4>Dark Sole Original</h4>
        <div>
          <p>$60</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>Light up the night with the Dark Sole Original. Lights around the midsole activate when stomped.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>9</li>
            <li>10</li>
            <li>10.5</li>
            <li>11</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <!-- Shopping cart -->
  <div class='shopping-cart'>
    <div class='container'>
      <div class='cart'>
        <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/shopping-cart.svg'></object>
        <h3 class='items-qty'>1</h3>
      </div>
      <h3>Checkout</h3>
    </div>
  </div>

  <footer>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>Contact Us</div>
    </div>
  </footer>
  <script
  src="https://code.jquery.com/jquery-3.2.1.min.js"
integrity="sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4=" crossorigin="anonymous"></script>
  <script src='js/main.js'></script> 
</body>

</html>

//main.js ready

$(document).ready(() => {

});
//some class .handlerMethod .. show

//some id
$(document).ready(() => {

$('#nav-dropdown').hide();
});

//in a variable

$(document).ready(() => {
  const $navDropDown = $('#nav-dropdown');
  $navDropDown.hide();
});

//event handler
$(document).ready(() => {
  const $menuButton = $('.menu-button');
  const $navDropdown = $('#nav-dropdown');

  $($menuButton).on('click', () => {
  $navDropdown.show();
})

})

/*review
/*
.addClass()
A JavaScript file can quickly get overloaded with styles if you regularly use the css method to modify element styles. It’s a best practice to group all of the style code in a CSS file, and use jQuery to add and remove the classes from elements — this approach aligns to a design principle called separation of concerns.

Separation of concerns is a design principle stating that code should be separated based on its purpose in a program. In web development, that generally means the structure of a page is defined in an HTML document, styles are stored in a CSS file, and code that defines dynamic behavior is stored in a JavaScript file.

To keep CSS properties in a CSS file, jQuery can add a CSS class to an element with a method named addClass. It’s syntax looks like this:

$('.example-class').addClass('active');
In the example above:

.addClass() is called on the jquery .example-class selector.
.addClass() adds the 'active' class to all .example-class elements.
Notice that the argument passed to addClass does not have a period preceding it. This is because it expects a class, and therefore only needs the name of the class.
Instructions
1.
Instead of changing the text color and background color with the .css() method, replace the code in the menu button mouse enter handler with the .addClass() method.

If you navigate to css/styles.css, there’s a class named .button-active, which defines the text color and background color of an element. Use the .addClass() method to add button-active to the .menu-button element when it’s moused over.
*/

dy(() => {
 
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.menu-button').addClass('button-active');//in styles.css instead
    $('.menu-button').animate({
      fontSize: '24px'
      }, 200);
    $('.nav-menu').show();
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.menu-button').css({
      color: '#EFEFEF',
      backgroundColor: '#303030'
      });
    $('.menu-button').animate({
      fontSize: '18px'
      }, 200);
    $('.nav-menu').hide();
  })
  
}); 


Query to add dynamic behavior to a website. With jQuery objects, you can quickly target elements, handle events and add visual effects with just a few lines of code.

That said, when using any jQuery tools, it is important to consider how events and effects will appear on different platforms.

In this lesson, you learned:

About JavaScript libraries.
How to add jQuery to your web page.
How to avoid loading errors with the .ready() method.
About jQuery objects and their methods.
How to target elements by id and class.
Naming conventions for storing jQuery objects in JavaScript variables.
How to add event handlers with .on().
A couple jQuery effects, such as .hide() and .show().
Nice work!

Instructions
In main.js, we added another .on() callback function, this time on the $navDropdown object.

We passed it 'mouseleave' with a callback function that hides the $navDropdown object. Before you run the code, read through it and predict the behavior this code causes in the web page.

When you’re ready, run the code.
*/

$(document).ready(() => {
  const $menuButton = $('.menu-button');
  const $navDropdown = $('#nav-dropdown');

  $menuButton.on('click', () => {
    $navDropdown.show();
  })
  
  $navDropdown.on('mouseleave', () => {
    $navDropdown.hide();
  })
})


//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>//main.js maddison dropdown

$(document).ready(() => {
  $('#cart').on('click', () => {
    $('#cartMenu').show();
  })

  $('#account').on('click', () => {
    $('#accountMenu').show();
  })

  $('#help').on('click', () => {
    $('#helpMenu').show();
  })

  $('.dropdown-menu').on('mouseleave', () => {
    $('.dropdown-menu').hide();
  })

})
// styles.css
html, body {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Montserrat', sans-serif;
}

.container {
  max-width: 1024px;
  margin: 0 auto;
}

/* Header */
.header {
  padding: 45px 0;
  background-color: #0074ff;
}

.header ul {
  list-style: none;
  padding: 0;
}

.header li {
  display: inline;
  line-height: 30px;
}

.header li + li {
  margin-left: 30px;
}

.header h1 {
  margin: 0;
  font-size: 20px;
  color: #fff;
}

.header h3 {
  color: #fff;
  font-size: 14px;
  display: inline-block;
  margin: 0;
  font-weight: normal;
  cursor: pointer;
}

.header .dropdown {
  position: relative;
}

.header .dropdown-menu {
  position: absolute;
  top: 20px;
  border-radius: 0;
}

.header .dropdown-menu li {
  display: block;
  margin: 0;
  padding: 3px 10px;
}

/* Main */
.main {
  background: url('https://s3.amazonaws.com/codecademy-content/projects/2/madison-square-market/s1.jpg') no-repeat center center;
  background-size: cover;
  height: 400px;
  width: 100%;
}

/* Footer */
.footer {
  background-color: #0074ff;
  padding: 20px 0;
  height: 200px;
}


@media (max-width: 1024px) { 
  .header h1 { 
    width: 100%; 
    text-align: center; 
  } 

  .pull-right { 
    float: none !important; 
    margin: 20px auto 0; 
    width: 225px;
  }
}


//index.html

<!doctype html>
<html>

  <head>
    <link rel="stylesheet" href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link rel='stylesheet' href='styles.css'/>
  </head>

  <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-md-4">
            <h1>madison square market</h1>
          </div>
          <div class="pull-right">

            <ul>

              <li class="dropdown" id="cart">
                <h3>cart &#x25BE;</h3>
                <ul class="dropdown-menu" id="cartMenu">
                  <li>View Cart</li>
                  <li>Saved Carts</li>
                </ul>
              </li>

              <li class="dropdown"  id="account">
                <h3>account &#x25BE;</h3>
                <ul class="dropdown-menu" id="accountMenu">
                  <li>View Account</li>
                  <li>Check Order Status</li>
                  <li>Sign in</li>
                </ul>
              </li>

              <li class="dropdown"  id="help">
                <h3>help &#x25BE;</h3>
                <ul class="dropdown-menu" id="helpMenu">
                  <li>FAQs</li>
                  <li>Return Policy</li>
                  <li>Shipping Info</li>
                </ul>
              </li> 

            </ul>

          </div>
        </div>
      </div>
    </div>

    <div class="main"></div>
    <div class="footer"></div>

    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='main.js'></script>
  </body>
</html>

.*
.hide()
The first tool you will add to your jQuery effects tool belt is the .hide() method. When you hide an element, your browser will render the HTML as if the hidden element does not exist. It will disappear from the page and the space that it was taking up will disappear as well. Take a look at the code below to learn how to use the .hide() method:

$('.hide-arrow').on('click', () => {
  $('.shoe-information').hide();
});
In the example above, the event handler gets triggered whenever an element with a class of hide-arrow is clicked. That element could be a button, some text, an image, or any other HTML element. When the event is triggered, we target all elements of the class shoe-information and call .hide() on them. Check out the gif below to see an example.

￼
In this gif, the shoe-information element hides when the hide-arrow button is clicked. Notice that the HTML elements below the shoe-information element move up to fill the space left by the hidden element.
*/
 //hide
$(document).ready(() => {
 $('.hide-button').on('click', () => {
   $('.first-image').hide();
 })
})

//and show

$(document).ready(() => {
  $('.hide-button').on('click', () => {
    $('.first-image').hide();
  });
  
  $('.show-button').on('click', () => {
    $('.first-image').show();
  });
  
});

//and toggle which toggles hide and show e.g., display: hidden

$(document).ready(() => {
  $('.hide-button').on('click', () => {
    $('.first-image').hide();
  });
  
  $('.show-button').on('click', () => {
    $('.first-image').show();
  });
  
  $('.toggle-button').on('click', () => {
    $('.first-image').toggle();
  });
  
});


//fadein fadeout specify millisecs as argument

$(document).ready(() => {
  $('.hide-button').on('click', () => {
    $('.first-image').hide();
  });
  
  $('.show-button').on('click', () => {
    $('.first-image').show();
  });
  
  $('.toggle-button').on('click', () => {
    $('.first-image').toggle();
  });
  
  $('.fade-out-button').on('click', () => {
    $('.fade-image').fadeOut(500);
  });
  
  $('.fade-in-button').on('click', () => {
    $('.fade-image').fadeIn(4000);
  });
  
});


//toggle fade as toggle accepts keywords like 'fast' too

$(document).ready(() => {
  $('.hide-button').on('click', () => {
    $('.first-image').hide();
  });
  
  $('.show-button').on('click', () => {
    $('.first-image').show();
  });
  
  $('.toggle-button').on('click', () => {
    $('.first-image').toggle();
  });
  
  $('.fade-out-button').on('click', () => {
    $('.fade-image').fadeOut(500);
  });
  
  $('.fade-in-button').on('click', () => {
    $('.fade-image').fadeIn(4000);
  });
  
  $('.fade-toggle-button').on('click', () => {
    $('.fade-image').fadeToggle('fast');
  });
});

//slideimage an effect not scrollbar

$(document).ready(() => {
  $('.hide-button').on('click', () => {
    $('.first-image').hide();
  });
  
  $('.show-button').on('click', () => {
    $('.first-image').show();
  });
  
  $('.toggle-button').on('click', () => {
    $('.first-image').toggle();
  });
  
  $('.fade-out-button').on('click', () => {
    $('.fade-image').fadeOut(500);
  });
  
  $('.fade-in-button').on('click', () => {
    $('.fade-image').fadeIn(4000);
  });
  
  $('.fade-toggle-button').on('click', () => {
    $('.fade-image').fadeToggle();
  });
  
  $('.up-button').on('click', () => {
    $('.slide-image').slideUp(100);
  });
  
  $('.down-button').on('click', () => {
    $('.slide-image').slideDown('slow');
  });
  
  $('.slide-toggle-button').on('click', () => {
    $('.slide-image').slideToggle();//400
  });
  
});
/*
Review: Effects
Wow! You’ve completed this table of 9 different jQuery effects. Great job! To review, the methods that we learned were:

.hide()
.show()
.toggle()
These methods instantly hide or show elements on a web page.

.fadeOut()
.fadeIn()
.fadeToggle()
These methods make elements disappear or appear over a given period of time.

.slideUp()
.slideDown()
.slideToggle()
These methods make elements slide up or down into place over a given period of time.

Using these effects, you can make your web pages eye-catching and dynamic. And thanks to the magic of jQuery all of this can be done with very few lines of code!

Instructions
Your table is complete. Congratulations! Now take some time to tweak it and make it your own.

Can you change your code so a button applies its effect to all 3 images?
Can you make every button apply its effect to only the first image?
What happens when you apply effects one after another? For example, what happens when you apply .slideUp(), then .hide(), then .slideDown() to an image?
*/
//see trivia

/*
Introduction to Mouse Events
The jQuery library provides a collection of methods that serve one of two purposes.

To listen for an event — an event (e.g. clicking a button) is something the user does to trigger an action.
To add a visual effect — a visual effect (e.g. a drop-down menu appearing when a user clicks a button) is something that changes the appearance of the web page. Events are often responsible for triggering a visual effect.
In this lesson, you will learn how to link a user event to a visual effect using event handlers.

There are two parts to an event handler: an event listener and a callback function.

An event listener is a method that listens for a specified event to occur, like a click event.
A callback function is a function that executes when something triggers the event listener.
Both the event listener and callback function make up an event handler.

In code, this looks like:

$('.example-class').on('click', () => {
    // Execute code here when .example-class is clicked
});
Let’s consider the example above step-by-step:

$('.example-class') selects all HTML elements with a class of example-class.
The on('click') method is the event listener. It checks if the user has clicked an .example-class HTML element.
The second argument to .on() is a callback function. When a 'click' occurs on an example-class element, this function executes.
Instructions
1.
Replace the ____ in the .on() method with click.

Run the code and click the login button.

Nice work, the login button now listens for a click event. The callback function in the event handler displays a login form when you click the button.
*/
$(document).ready(() => {
  $('.login-button').on('click', () => {
    $('.login-form').show();
  })
  
  
}); 

//

$(document).ready(() => {
  $('.login-button').on('click', () => {
    $('.login-form').show();
  });
  $('.menu-button').on('mouseenter', () => {
    $('.nav-menu').show();
  });

}); 



//

$(document).ready(() => {
  $('.login-button').on('click', () => {
    $('.login-form').show();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.nav-menu').show()
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.nav-menu').hide();
  })
  
}); 

//chaining
/*
$('.example-class').on('mouseenter', () => {
  $('.example-class-one').show();
}).on('mouseleave', () => {
  $('.example-class-one').hide();
});
*/



$(document).ready(() => {
  $('.login-button').on('click', () => {
    $('.login-form').show();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.nav-menu').show()
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.nav-menu').hide();
  })
  
  $('.product-photo').on('mouseenter', () => {
    $('.product-photo').addClass('photo-active');//no period in addClass/removeClass for class
  }).on('mouseleave', () => {
    $('.product-photo').removeClass('photo-active');
  })
}); 

/*
MOUSE EVENTS
currentTarget
Have you noticed in our Sole Shoes website that when you mouse over one photo, all of the images zoom. That’s because .product-photo is a class on all the product photos.

One way to solve this issue is to give each HTML element a unique class and to write three mouseenter and mouseleave functions. That, however, would result in a lot of repetitive code. Luckily there’s a better way.

The solution is in the callback function and selector we’re using when we add a new class. Instead of selecting $('.product-photo') in each callback function, we need to pass event information into the function and call the currentTarget attribute:

$('.example-class').on('mouseenter', event => {
  $(event.currentTarget).addClass('photo-active');
});
The points below explain some of the features of the event.currentTarget selector in the example above.

When a user triggers the mouseenter event listener above, the .on() method generates an event object that we pass into the callback function.
Inside the callback function, we select event.currentTarget. The currentTarget attribute refers to only the .example-class element that the learner has moused over.
Since $(event.currentTarget) refers to the element that an event is detected on, you will only use it inside a callback function.
In our Sole Shoes website, we will use $(event.currentTarget) to target the one image a user mouses over.
*/

$(document).ready(() => {
  $('.login-button').on('click', () => {
    $('.login-form').show();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.nav-menu').show()
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.nav-menu').hide();
  })
  
  $('.product-photo').on('mouseenter', event => {
    $(event.currentTarget).addClass('photo-active')
  }).on('mouseleave', event => {
    $(event.currentTarget).removeClass('photo-active')
  })
  
}); 
//index.html

<!DOCTYPE html>
<html>

<head>
  <title>Sole Shoes</title>
  <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,700' rel='stylesheet'>
  <link href='https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700' rel='stylesheet'>
  <link rel='stylesheet' type='text/css' href='css/styles.css'>
</head>

<body>

  <!-- Navigation -->
  <nav>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>
        <span class='menu-button'>Menu</span>
        <span class='login-button'>Login</span>
      </div>
    </div>
  </nav>

  <!-- Nav Menu -->
  <div class='nav-menu hide'>
    <div class='container'>
      <ul>
        <li>Shoes</li>
        <li>Women's Shoes</li>
        <li>Men's Shoes</li>
        <li>Shoe Accessories</li>
        <li>Wholesale</li>
      </ul>
      <ul>
        <li>Contact</li>
        <li>Twitter</li>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>Email</li>
      </ul>
    </div>
  </div>

  <!-- Login Form -->
  <div class='login-form'>
    <div class='container'>
      <form>
        <h4>Username</h4>
        <input class='username' />
        <h4>Password</h4>
        <input type='password' />
        <input class='sign-in-button' type='submit' value='Sign In' />
      </form>
    </div>
  </div>

  <!-- Product Cards -->
  <div class='container'>
    <div class='product-card'>
      <div class='product-photo sole-air-ii'></div>
      <div class='product-details'>
        <h4>Sole Air II</h4>
        <div>
          <p>$35</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The ultimate in style and comfort, the Sole Air II's are great for walking and casual wearing.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>8</li>
            <li>9</li>
            <li>10</li>
            <li>11</li>
            <li>12</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo tidal-x'></div>
      <div class='product-details'>
        <h4>Tidal X</h4>
        <div>
          <p>$40</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The Tidal X's signature rubber midsole make this the perfect running shoe. With a soft mesh upper, and synthetic polymer outsole, these shoes really fly.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>6</li>
            <li>7</li>
            <li>10</li>
            <li>12</li>
            <li>13</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>

    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo dark-sole-original'></div>
      <div class='product-details'>
        <h4>Dark Sole Original</h4>
        <div>
          <p>$60</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>Light up the night with the Dark Sole Original. Lights around the midsole activate when stomped.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>9</li>
            <li>10</li>
            <li>10.5</li>
            <li>11</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <!-- Shopping cart -->
  <div class='shopping-cart'>
    <div class='container'>
      <div class='cart'>
        <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/shopping-cart.svg'></object>
        <h3 class='items-qty'>1</h3>
      </div>
      <h3>Checkout</h3>
    </div>
  </div>

  <footer>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>Contact Us</div>
    </div>
  </footer>

   <script
    src="https://code.jquery.com/jquery-3.2.1.min.js"
    integrity="sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4="
    crossorigin="anonymous"></script> 

  <script src='js/main.js'></script> 
</body>

</html>

//styles.css

* {
  margin: 0;
  padding: 0;
  transition: 0.1s; }

body {
  font-family: 'Roboto Condensed', Helvetica, sans-serif;
  text-align: left;
  font-size: 18px;
  color: #303030; }

.container {
  max-width: 450px;
  margin: 0 auto; }

h3 {
  color: #C3FF00;
  font-weight: 700;
  text-transform: uppercase;
  letter-spacing: 0.1em; }

h4 {
  text-transform: uppercase; }

.disabled h3 {
  color: #535353;
  cursor: not-allowed; }

.button-active {
  color: #C3FF00;
  background-color: #535353; }

nav {
  background-color: #303030;
  color: #EFEFEF; }
  nav .container {
    display: flex;
    justify-content: space-between;
    align-items: center; }
    nav .container object {
      width: 4.5em;
      padding: 1.2em 0.5em; }
    nav .container .login-button,
    nav .container .menu-button {
      text-transform: uppercase;
      letter-spacing: 0.1em;
      padding: 1em 1.25em;
      -webkit-user-select: none;
      -moz-user-select: none;
      -ms-user-select: none;
      user-select: none;
      cursor: pointer; }

.nav-menu {
  background-color: #535353;
  color: #EFEFEF;
  display: flex;
  justify-content: center; }
  .nav-menu .container {
    padding: 1.5em;
    display: flex; }
    .nav-menu .container ul {
      list-style: none; }
      .nav-menu .container ul li {
        padding: 0.25em 2em; }
        .nav-menu .container ul li:first-child {
          text-transform: uppercase;
          color: #C3FF00;
          letter-spacing: 0.05em; }

.hide {
  display: none; }

.login-form {
  background-color: #535353;
  padding: 1em 0 0;
  color: #EFEFEF;
  display: none; }
  .login-form .container {
    padding: 0 0.5em; }
  .login-form h4 {
    font-weight: 400; }
  .login-form input {
    width: calc(100% - 1em);
    border: none;
    height: 2em;
    margin: 0.5em 0;
    font-size: 1em;
    padding: 0 0.5em; }
  .login-form .sign-in-button {
    background-color: #303030;
    color: #C3FF00;
    font-weight: 700;
    text-transform: uppercase;
    letter-spacing: 0.1em;
    text-align: center;
    width: 100%;
    height: 2.5em;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    cursor: pointer; }

.product-card {
  margin: 1em 0; }
  .product-card .dark-sole-original,
  .product-card .sole-air-ii,
  .product-card .tidal-x {
    background-size: 28em 15em;
    background-position: center;
    height: 14em;
    transition: 0.2s; }
  .product-card .sole-air-ii {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-air-ii.png"); }
  .product-card .tidal-x {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/tidal-x.png"); }
  .product-card .dark-sole-original {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/dark-sole-original.png"); }
  .product-card .photo-active {
    background-size: 30.8em 16.5em;
    transition: 0.2s; }
  .product-card .product-details {
    margin-top: -5px;
    background-color: #EFEFEF;
    display: flex;
    justify-content: space-between; }
    .product-card .product-details h4,
    .product-card .product-details p {
      padding: 0.7em 1.25em; }
    .product-card .product-details div {
      display: flex; }
    .product-card .product-details .more-details-button {
      background-color: #535353;
      padding: 0.75em 1.25em;
      cursor: pointer;
      width: 1em;
      transition: 0.1s; }
      .product-card .product-details .more-details-button img {
        position: relative;
        left: 0.1em; }
      .product-card .product-details .more-details-button .rotate {
        transition: 0.1s;
        transform: rotate(90deg); }
  .product-card .shoe-details {
    display: none;
    background-color: #535353;
    color: #EFEFEF; }
    .product-card .shoe-details .active {
      background-color: #C3FF00;
      color: #303030; }
  .product-card .size-chart,
  .product-card p {
    padding: 1em 1.25em; }
    .product-card .size-chart ul,
    .product-card p ul {
      list-style: none;
      display: flex;
      justify-content: space-around;
      margin-top: 1em; }
      .product-card .size-chart ul li,
      .product-card p ul li {
        padding: 0.5em;
        background-color: #303030;
        width: 100%;
        text-align: center;
        margin-right: 2px; }
  .product-card .buy-now-button {
    background-color: #303030;
    text-align: center;
    padding: 0.75em;
    cursor: pointer; }

.shopping-cart {
  background-color: #171717;
  position: fixed;
  bottom: 0;
  z-index: 99;
  width: 100%;
  box-shadow: 2px 0 4px 0 rgba(0, 0, 0, 0.5);
  display: none;
  height: 3.5em; }
  .shopping-cart .container {
    display: flex;
    justify-content: space-between;
    padding: 1em; }
    .shopping-cart .container .cart {
      display: flex; }
      .shopping-cart .container .cart object {
        margin-right: 0.75em; }

footer {
  color: #EFEFEF;
  background-color: #303030;
  margin-top: 2em;
  padding: 2em 0.5em; }
  footer .container {
    display: flex;
    justify-content: space-between; }
    footer .container object {
      width: 4.5em; }

//review
/*
MOUSE EVENTS
Review: Event Handlers
In this lesson, you learned a few of the most common mouse events in the jQuery library.

Event handlers are comprised of an event listener and a callback function. An event listener specifies the type of event that will be detected. The callback function executes when the event happens. Everything together is the event handler.
An event listener is set up using the .on() method.
The events listened for included: 'click', 'mouseenter', and 'mouseleave'.
In addition to event handlers, you learned how to use event.currentTarget to refer to the individual element that an event occurred on.
Well done! At this point, you understand the purpose of an event, and how to link it to a callback function. Use jqapi.com to learn about some other events that jQuery has to offer. Select Events in the left navigation bar to browse these other events.

Instructions
If you want a challenge, try to add some new events to the Sole Shoes website — use the list event listeners below to help.

Mouse events
dblclick
mousemove
Though they are not used as frequently, jQuery also supports keyboard events. If you’re looking for a challenge, give the following event listeners a try:

Keyboard events
keydown
keypress
keyup
*/

/*
Does JavaScript have an equivalent to the jQuery .on() method with event listener and callback?

Answer
The JavaScript equivalent to jQuery’s .on method is the .addEventListener() method. The syntax looks like this:

targetElement.addEventListener('eventlistener', callback);
where targetElement is the selected element to add the event handler to, 'eventlistener' is the event to listen for - like 'click', 'mouseenter', 'mouseleave', etc., and the callback is the function that executes when the event listener is triggered.*/


//project feedster

//main.js

$(document).ready(() => {
  $('.menu').on('mouseover', () => {
    $('.nav-menu').show();
  }).on('mouseleave', () => {
    $('.nav-menu').hide();
  })
  /*('.btn').on('mouseenter', () => {
    $('.btn').addClass('btn-hover')
  })*/ //targets all .btn
  //below targets current .btn
  $('.btn').on('mouseenter', event => {
    $(event.currentTarget).addClass('btn-hover')
  }).on('mouseleave', event => {
    $(event.currentTarget).removeClass('btn-hover')
  })
  
  $('.postText').focus();
  $('.postText').on('keyup', event => {
    const post = $(event.currentTarget).val();
    const remaining = 140 - post.length;
    if (remaining <= 0) {
      $('.wordcount').addClass('red');
    } else {
      $('.wordcount').removeClass('red');
    }
    $('.characters').html(remaining);
  })
}); 

//index.html

<!DOCTYPE html>
<html>
<head>
	<title>feedster</title>
	<link href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,700" rel="stylesheet" type="text/css">

<link href="styles.css" rel="stylesheet">
</head>
 <body>
    <div class="header">
      <div class="container">
        <div class="row">
          <div class="col-xs-2">
            <h1>feedster</h1>
          </div>
          <div class="col-xs-7">
          </div>
          
          <div class="col-xs-2">
            <h1 class="menu">menu</h1>
          </div>
        </div>
      </div>
    </div>
   

  <div class='nav-menu'>
    <div class='container-nav'>
      <ul>
        <li>Bang Bang</li>
        <li>Mexican-Chinese</li>
        <li>Indo-Scandinavian</li>
        <li>Polish-Korean</li>
      </ul>
      <ul>
        <li>Contact</li>
        <li>Twitter</li>
        <li>Facebook</li>
        <li>Instagram</li>
      </ul>
    </div>
  </div>
    
    <form method= "POST" class="newPost">
      <div class="container">
        <div class="post">
          <img class="avatar" src="https://s3.amazonaws.com/codecademy-content/courses/jquery+jfiddle+test/feedster/profile-purple.svg">
          <h3 class='name'>YOUR NAME HERE</h3>
          <textarea class="postText" placeholder="What's on your mind?"></textarea>
          <p class="wordcount"><span class='characters'>140</span> characters remaining</p>
          <div class="button-holder">
            <button type="submit" class="btn-post">POST</button>
            <button type="submit" class="btn-post">WORD COUNT</button>
          </div>
        </div>
      </div>
    </form>
    
    <div class="posts">
      <div class="container">
        <div class="post">
          <img class="avatar" src="https://s3.amazonaws.com/codecademy-content/courses/jquery+jfiddle+test/feedster/profile-teal.svg">
          <h3>Ivory Breath</h3>
          <p>Buffalo bulgogi, are you kidding me!?! Do yourself a favor and head to this restaurant.</p>
          <button class="btn">+1</button>
        </div>

        <div class="post">
          <img class="avatar" src="https://s3.amazonaws.com/codecademy-content/courses/jquery+jfiddle+test/feedster/profile-yellow.svg">
          <h3>Bacon West</h3>
          <p>Tacos, sausage, fundido, saurkraut and more! 10/10 would recommend.</p>
          <button class="btn">+1</button>
        </div>
        
      </div>
    </div>
   
   <script
    src="https://code.jquery.com/jquery-3.2.1.min.js"
    integrity="sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4="
    crossorigin="anonymous"></script> 

  <script src='main.js'></script> 
  </body>

</html>

//styles.css

html, body {
  margin: 0;
  padding: 0;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", "Roboto", "Ubuntu", "Cantarell", "Fira Sans", "Droid Sans", "Helvetica Neue", sans-serif;
}

body {
  background-color: CornflowerBlue;
}

.container {
  max-width: 700px;
  height: 100%;
  margin: 0 auto;
}

.header {
  background-color: #19314D;
}

.header h1 {
  font-family: 'Source Sans Pro', sans-serif;
  font-size: 32px;
  font-weight: 200;
  color: #fff;
  margin: 0;
  padding: 7px 0;
}

.nav-menu {
  background-color: #19314D;
  color: #EFEFEF;
  display: none;
  justify-content: flex-start;
}
  .nav-menu .container-nav {
    padding: 1.5em;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
   }
    .nav-menu .container-nav ul {
      list-style: none;
      margin: 0;
      padding: 0;
      }
      .nav-menu .container-nav ul li {
        padding-top: .25em; 
        }
        .nav-menu .container-nav ul li:first-child {
          text-transform: uppercase;
          color: CornflowerBlue;
          letter-spacing: 0.05em;}



.post {
  background-color: #fff;
  border-radius: 4px;
  padding: 10px;
  margin: 20px 0;
  box-shadow: 0px 0px 4px 0px rgba(0, 0, 0, 0.3);
}

form .post {
    min-height: 186px;
}

.post .avatar {
  margin: 0 10px 10px 0;
}

.post h3 {
  font-weight: 700;
  font-size: 16px;
  margin-top: 0;
  display: inline;
}

.post p {
  font-size: 14px;
}

.post p + img {
  width: 100%;
  margin-bottom: 15px;
}

.btn {
  color: #00CD73;
  border-color: #00CD73;
  background-color: transparent;
  font-weight: 700;
}

.btn-hover {
  color: white;
  border-color: #00CD73;
  background-color: #00CD73;
  font-weight: 700;
}

.btn-post{
  color: CornflowerBlue;
  border-color: CornflowerBlue;
  border-radius: 4px;
  border-width: 1px;
  text-decoration: none;
  background-color: transparent;
  font-weight: 700;
  padding: 5px;
  float: right;
  margin-right: 20px;
}

.btn-post:hover {
  color: white;
  border-color: CornflowerBlue;
  background-color: CornflowerBlue;
  font-weight: 700;
}

.postText {
  width: 100%;
  display: block;
  word-wrap: break-word;
  height: 60px;
  resize: none;
}

textarea{
  background-color: #F2F2F2;
  border: none;
  box-shadow: inset 0px 1px 1px 0px rgba(0, 0, 0, 0.1);
  line-height: 20px;
  font-size: 14px;
  padding: 10px;  
}

.wordcount {
  color: #9B9B9B;
  font-size: 9px;
  line-height: 24px;
  opacity: .8;
}

.red {
  color: red;
}

/*
.css()
To modify CSS properties of an element, jQuery provides a method called .css(). This method accepts an argument for a CSS property name, and a corresponding CSS value.

It’s syntax looks like:

$('.example-class').css('color', '#FFFFFF');
Let’s break the example above into two pieces:

We call the .css() method on .example-class. The first argument is the CSS property we want to change. In this case, that’s 'color'.
The second argument specifies the new value for the given property in the first argument. In this case, the .css() method changes the color of .example-class elements to '#FFFFFF'.
Notice, both of the inputs to the .css() method are strings.
*/
$(document).ready(() => {
 
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.menu-button').css('color', '#C3FF00');
    $('.nav-menu').show();
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.menu-button').css('color', '#EFEFEF');
    $('.nav-menu').hide();
  })
  
}); 

/*
CSS II
In addition to changing one property at a time, the .css() method can accept many CSS property/value pairs at once. You must pass the .css() method a JavaScript object with a list of key/value pairs like this:

{
  color: '#FFFFFF',
  backgroundColor: '#000000',
  fontSize: '20px'
}
There are a few important differences between the key/value pairs in the object above and the arguments from last exercise. Let’s consider these differences below:

The object is wrapped by an opening and closing curly brace: {}.
Inside the object, there are three key/value pairs. The keys in the example object are color, backgroundColor, and fontSize.
The values come after the colon : of each key. For instance, fontSize is a key, and its value is '20px'.
When referencing CSS properties in an object, the property names are camelCased — they are modified to have no quotes or spaces, and to start each new word with a capital letter. Therefore, background-color becomes backgroundColor, and 'font-size' becomes fontSize.
To set multiple properties at once, you can pass the whole object into the .css() method as a single element.

$('.example-class').css({
  color: '#FFFFFF',
  backgroundColor: '#000000',
  fontSize: '20px'
})
In the example above, we use the .css() method to change the color, background color, and font size values of the .example-class element.
*/

//

$(document).ready(() => {
 
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.menu-button').css({
      color: '#C3FF00',
      backgroundColor: '#535353'
      });
    $('.nav-menu').show();
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.menu-button').css({
      color: '#EFEFEF',
      backgroundColor: '#303030'
      });
    $('.nav-menu').hide();
  })
  
}); 

/*

.animate()
The jQuery .animate() method enhances the visual possibilities by making CSS value changes over a period of time.

The first argument passed to .animate() is a JavaScript object of CSS property/value pairs that represent an element’s end state. This is identical to the .css() method. For example, the following object could be passed to the .animate() method to change an element’s height, width, and border thickness

{
  height: '100px',
  width : '100px',
  borderWidth : '10px'
}
Note that the names of CSS properties in the JavaScript object don’t have spaces or dashes and are camelCased.

The second parameter of the .animate() method determines how long the animation takes to complete. It is optional; if you do not provide an argument, the default value is 400 milliseconds. You can use a number (in milliseconds) or the strings 'fast' or 'slow'. Below is an example of the .animate() method:

$('.example-class').animate({
  height: '100px',
  width: '100px',
  borderWidth: '10px'
}, 500);
In the example above, the height, width, and border width will change to 100px, 100px, and 10px respectively over a 500 millisecond period

*/

//

$(document).ready(() => {
 
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.menu-button').css({
      color: '#C3FF00',
      backgroundColor: '#535353'
      });
    $('.menu-button').animate({
      fontSize: '24px'
      }, 200);
    $('.nav-menu').show();
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.menu-button').css({
      color: '#EFEFEF',
      backgroundColor: '#303030'
      });
    $('.menu-button').animate({
      fontSize: '18px'
      }, 200);
    $('.nav-menu').hide();
  })
  
}); 

/*
.addClass()
A JavaScript file can quickly get overloaded with styles if you regularly use the css method to modify element styles. It’s a best practice to group all of the style code in a CSS file, and use jQuery to add and remove the classes from elements — this approach aligns to a design principle called separation of concerns.

Separation of concerns is a design principle stating that code should be separated based on its purpose in a program. In web development, that generally means the structure of a page is defined in an HTML document, styles are stored in a CSS file, and code that defines dynamic behavior is stored in a JavaScript file.

To keep CSS properties in a CSS file, jQuery can add a CSS class to an element with a method named addClass. It’s syntax looks like this:

$('.example-class').addClass('active');
In the example above:

.addClass() is called on the jquery .example-class selector.
.addClass() adds the 'active' class to all .example-class elements.
Notice that the argument passed to addClass does not have a period preceding it. This is because it expects a class, and therefore only needs the name of the class.
Instructions
1.
Instead of changing the text color and background color with the .css() method, replace the code in the menu button mouse enter handler with the .addClass() method.

If you navigate to css/styles.css, there’s a class named .button-active, which defines the text color and background color of an element. Use the .addClass() method to add button-active to the .menu-button element when it’s moused over.
*/

/*

.removeClass()
Similar to .addClass(), the jQuery .removeClass() method can remove a class from selected elements.

Its syntax is similar to .addClass():

$('.example-class').removeClass('active');
In the example above:

.removeClass() is called on .example-class elements.
The method removes the 'active' class from all .example-class elements.
*/

//

$(document).ready(() => {
  
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.menu-button').addClass('button-active');
    $('.nav-menu').removeClass('hide');
    $('.menu-button').animate({
      fontSize: '24px'
      }, 200);
    $('.nav-menu').show();
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.menu-button').css({
      color: '#EFEFEF',
      backgroundColor: '#303030'
      });
    $('.menu-button').animate({
      fontSize: '18px'
      }, 200);
    $('.nav-menu').hide();
  })
  
}); 

/*
STYLE METHODS
.toggleClass()
Similar to other effects methods, you can use a toggle method instead of chaining the .addClass() and .removeClass() methods together.

The .toggleClass() method adds a class if an element does not already have it, and removes it if an element does already have it. Its syntax looks like:

$('.example-class').toggleClass('active');
In the example above:

.toggleClass() is called on .example-class elements.
.toggleClass() will add the 'active' class to .example-class elements if they do not have it already.
.toggleClass() will remove the 'active' class from .example-class elements if they do have it already.
1.
In main.js we changed the mouse enter event to a click event so you can see the changes that are caused by the .toggleClass() method below.

Let’s use .toggleClass() to add or remove the hide class from the navigation menu element.

Checkpoint 2 Passed
2.
Use .toggleClass() to add and remove the button-active class from the menu button.

*/

//
$(document).ready(() => {
  $('.login-button').on('click', () => {
    $('.login-form').show();
  });
  
  $('.menu-button').on('click', () => {
    $('.nav-menu').toggleClass('hide');
    $('.menu-button').toggleClass('button-active');
  })  
}); 

//index.html

<!DOCTYPE html>
<html>

<head>
  <title>Sole Shoes</title>
  <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,700' rel='stylesheet'>
  <link href='https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700' rel='stylesheet'>
  <link rel='stylesheet' type='text/css' href='css/styles.css'>
</head>

<body>

  <!-- Navigation -->
  <nav>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>
        <span class='menu-button'>Menu</span>
        <span class='login-button'>Login</span>
      </div>
    </div>
  </nav>

  <!-- Nav Menu -->
  <div class='nav-menu hide'>
    <div class='container'>
      <ul>
        <li>Shoes</li>
        <li>Women's Shoes</li>
        <li>Men's Shoes</li>
        <li>Shoe Accessories</li>
        <li>Wholesale</li>
      </ul>
      <ul>
        <li>Contact</li>
        <li>Twitter</li>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>Email</li>
      </ul>
    </div>
  </div>

  <!-- Login Form -->
  <div class='login-form'>
    <div class='container'>
      <form>
        <h4>Username</h4>
        <input class='username' />
        <h4>Password</h4>
        <input type='password' />
        <input class='sign-in-button' type='submit' value='Sign In' />
      </form>
    </div>
  </div>

  <!-- Product Cards -->
  <div class='container'>
    <div class='product-card'>
      <div class='product-photo sole-air-ii'></div>
      <div class='product-details'>
        <h4>Sole Air II</h4>
        <div>
          <p>$35</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The ultimate in style and comfort, the Sole Air II's are great for walking and casual wearing.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>8</li>
            <li>9</li>
            <li>10</li>
            <li>11</li>
            <li>12</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo tidal-x'></div>
      <div class='product-details'>
        <h4>Tidal X</h4>
        <div>
          <p>$40</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The Tidal X's signature rubber midsole make this the perfect running shoe. With a soft mesh upper, and synthetic polymer outsole, these shoes really fly.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>6</li>
            <li>7</li>
            <li>10</li>
            <li>12</li>
            <li>13</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>

    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo dark-sole-original'></div>
      <div class='product-details'>
        <h4>Dark Sole Original</h4>
        <div>
          <p>$60</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>Light up the night with the Dark Sole Original. Lights around the midsole activate when stomped.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>9</li>
            <li>10</li>
            <li>10.5</li>
            <li>11</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <!-- Shopping cart -->
  <div class='shopping-cart'>
    <div class='container'>
      <div class='cart'>
        <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/shopping-cart.svg'></object>
        <h3 class='items-qty'>1</h3>
      </div>
      <h3>Checkout</h3>
    </div>
  </div>

  <footer>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>Contact Us</div>
    </div>
  </footer>

   <script
    src="https://code.jquery.com/jquery-3.2.1.min.js"
    integrity="sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4="
    crossorigin="anonymous"></script> 

  <script src='js/main.js'></script> 
</body>

</html>

//styles.css

* {
  margin: 0;
  padding: 0;
  transition: 0.1s; }

body {
  font-family: 'Roboto Condensed', Helvetica, sans-serif;
  text-align: left;
  font-size: 18px;
  color: #303030; }

.container {
  max-width: 450px;
  margin: 0 auto; }

h3 {
  color: #C3FF00;
  font-weight: 700;
  text-transform: uppercase;
  letter-spacing: 0.1em; }

h4 {
  text-transform: uppercase; }

.disabled h3 {
  color: #535353;
  cursor: not-allowed; }

.button-active {
  color: #C3FF00;
  background-color: #535353; }

nav {
  background-color: #303030;
  color: #EFEFEF; }
  nav .container {
    display: flex;
    justify-content: space-between;
    align-items: center; }
    nav .container object {
      width: 4.5em;
      padding: 1.2em 0.5em; }
    nav .container .login-button,
    nav .container .menu-button {
      text-transform: uppercase;
      letter-spacing: 0.1em;
      padding: 1em 1.25em;
      -webkit-user-select: none;
      -moz-user-select: none;
      -ms-user-select: none;
      user-select: none;
      cursor: pointer; }

.nav-menu {
  background-color: #535353;
  color: #EFEFEF;
  display: flex;
  justify-content: center; }
  .nav-menu .container {
    padding: 1.5em;
    display: flex; }
    .nav-menu .container ul {
      list-style: none; }
      .nav-menu .container ul li {
        padding: 0.25em 2em; }
        .nav-menu .container ul li:first-child {
          text-transform: uppercase;
          color: #C3FF00;
          letter-spacing: 0.05em; }

.hide {
  display: none; }

.login-form {
  background-color: #535353;
  padding: 1em 0 0;
  color: #EFEFEF;
  display: none; }
  .login-form .container {
    padding: 0 0.5em; }
  .login-form h4 {
    font-weight: 400; }
  .login-form input {
    width: calc(100% - 1em);
    border: none;
    height: 2em;
    margin: 0.5em 0;
    font-size: 1em;
    padding: 0 0.5em; }
  .login-form .sign-in-button {
    background-color: #303030;
    color: #C3FF00;
    font-weight: 700;
    text-transform: uppercase;
    letter-spacing: 0.1em;
    text-align: center;
    width: 100%;
    height: 2.5em;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    cursor: pointer; }

.product-card {
  margin: 1em 0; }
  .product-card .dark-sole-original,
  .product-card .sole-air-ii,
  .product-card .tidal-x {
    background-size: 28em 15em;
    background-position: center;
    height: 14em;
    transition: 0.2s; }
  .product-card .sole-air-ii {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-air-ii.png"); }
  .product-card .tidal-x {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/tidal-x.png"); }
  .product-card .dark-sole-original {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/dark-sole-original.png"); }
  .product-card .photo-active {
    background-size: 30.8em 16.5em;
    transition: 0.2s; }
  .product-card .product-details {
    margin-top: -5px;
    background-color: #EFEFEF;
    display: flex;
    justify-content: space-between; }
    .product-card .product-details h4,
    .product-card .product-details p {
      padding: 0.7em 1.25em; }
    .product-card .product-details div {
      display: flex; }
    .product-card .product-details .more-details-button {
      background-color: #535353;
      padding: 0.75em 1.25em;
      cursor: pointer;
      width: 1em;
      transition: 0.1s; }
      .product-card .product-details .more-details-button img {
        position: relative;
        left: 0.1em; }
      .product-card .product-details .more-details-button .rotate {
        transition: 0.1s;
        transform: rotate(90deg); }
  .product-card .shoe-details {
    display: none;
    background-color: #535353;
    color: #EFEFEF; }
    .product-card .shoe-details .active {
      background-color: #C3FF00;
      color: #303030; }
  .product-card .size-chart,
  .product-card p {
    padding: 1em 1.25em; }
    .product-card .size-chart ul,
    .product-card p ul {
      list-style: none;
      display: flex;
      justify-content: space-around;
      margin-top: 1em; }
      .product-card .size-chart ul li,
      .product-card p ul li {
        padding: 0.5em;
        background-color: #303030;
        width: 100%;
        text-align: center;
        margin-right: 2px; }
  .product-card .buy-now-button {
    background-color: #303030;
    text-align: center;
    padding: 0.75em;
    cursor: pointer; }

.shopping-cart {
  background-color: #171717;
  position: fixed;
  bottom: 0;
  z-index: 99;
  width: 100%;
  box-shadow: 2px 0 4px 0 rgba(0, 0, 0, 0.5);
  display: none;
  height: 3.5em; }
  .shopping-cart .container {
    display: flex;
    justify-content: space-between;
    padding: 1em; }
    .shopping-cart .container .cart {
      display: flex; }
      .shopping-cart .container .cart object {
        margin-right: 0.75em; }

footer {
  color: #EFEFEF;
  background-color: #303030;
  margin-top: 2em;
  padding: 2em 0.5em; }
  footer .container {
    display: flex;
    justify-content: space-between; }
    footer .container object {
      width: 4.5em; }

/*review

Review: Style Methods
jQuery can be a wizard at managing your CSS, but as with any powerful magic, it must be handled with care and consideration or you’ll end up with a giant mess!

There may be instances where modifying specific CSS properties with jQuery makes sense, but as a best practice, it’s best to maintain an organized CSS file and use jQuery to manipulate clearly defined and well-named CSS classes.

In this lesson, you learned:

The .css() method can change style properties of an element.
The .css() method can accept multiple styles at once if you pass it a JavaScript object as its argument.
The .animate() method can change specific style properties over a period of time.
The .addClass() will add a CSS class to an element, and the .removeClass() method will remove a CSS class.
The .toggleClass() method will toggle a class on or off an element.
Incredible work! In the next lesson, you’ll learn about logical selectors. This will enable to you add a click event to one element, and make something happen elsewhere on the page.
*/

//review main.js

$(document).ready(() => {
  
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
  });
  
  $('.menu-button').on('mouseenter', () => {
    $('.menu-button').addClass('button-active');
    $('.nav-menu').removeClass('hide');
    $('.menu-button').animate({
      fontSize: '24px'
      }, 200);
    $('.nav-menu').show();
  })
  
  $('.nav-menu').on('mouseleave', () => {
    $('.menu-button').css({
      color: '#EFEFEF',
      backgroundColor: '#303030'
      });
    $('.menu-button').animate({
      fontSize: '18px'
      }, 200);
    $('.nav-menu').hide();
  })
  
}); 

//safe font preview project
//main.js
$(document).ready(() => {
  $('#text').on('keyup', event => {
    const current = $(event.currentTarget).val();
    $('.preview').html(current);
  });
  $('#font').on('change', event => {
    const current = $(event.currentTarget).val();
    $('.preview').css({
      fontFamily: current
    })
  });

  $('#weight').on('change', event => {
    const current = $(event.currentTarget).val();
    $('.preview').css({
      fontWeight: current
    })
  });

  $('#size').on('keyup', event => {
    const fontSize = $(event.currentTarget).val() + 'px';
    $('.preview').css({
      fontSize: fontSize
    })
  });

})

//index.html

<!DOCTYPE html>
<html>
<head>
	<title>Typo | Test-drive your text</title>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <link href="styles.css" rel="stylesheet">
</head>
<body>
  <div class = "outer-container">
  <header>
    <h1>TYP</h1>
    <h2>Test-drive your text</h2>
  </header>
  <div class="formHolder">
    <form method="POST">
      <div class="third">
        Font Family <select name="font" id="font">
          <option value="helvetica" id="helvetica">Helvetica</option>
          <option value="times" id="times">Times</option>
          <option value="impact" id="impact">Impact</option>
          <option value="courier" id="courier">Courier</option>
          <option value="verdana" id="verdana">Verdana</option>
        </select>
      </div>
      <div class="third">
        Font Size  
        <br>
        <input type="text" placeholder="12" id="size">
      </div>
      <div class="third">
        Font Weight  <select name="weight" id="weight">
         <option value="normal">Normal</option>
         <option value="bold">Bold</option>
         <option value="bolder">Bolder</option>
         <option value="lighter">lighter</option>
       </select>
      </div>
    </form>
  </div>
  <div class="preview">Sample Font</div>
  <textarea name="text" placeholder="Type something here and see what happens..." id="text" cols="30" rows="10"></textarea>
  </div>
</body>
<script src="main.js"></script>
</html>

//styles.css

body {
  background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/images/typetile.png");
  background-repeat: repeat;
  margin: 0;
  padding: 0;
}

.outer-container{
  width: 100%;
}
h1 {
  color: #FF6D04;
  font-size: 4rem;
  font-weight: 300;
  letter-spacing: 10px;
  line-height: 1rem;
  text-align: center;
} 

h2 {
  color: #665C3D;
  font-size: .9rem;
  font-weight: 100;
  letter-spacing: 2px;
  margin-bottom: 40px;
  text-transform: uppercase;
  text-align: center;
} 

header {
  text-align: center;
  font-family: "verdana";
}

.preview {
  align: center;
  background: white;
  font-family: Helvetica;
  font-size: 12px;
  font-weight: normal;
  margin: 0 auto 0 auto;

  min-height: 150px;
  padding: 30;
  word-wrap: break-word;
}

textarea {
  border-color: #E6B000;
  border-radius: 4px;
  border-style: solid;
  border-width:1px;
  display: block;
  font-family: "Helvetica-Light", "Helvetica", "Arial", Arial, sans-serif;
  font-size: 14px;
  line-height: 20px;
  margin: 30px auto 30px auto;
  padding: 20px;
}

.formHolder {
  background-color: #665C3D;
  border-radius: 4px 4px 0px 0px;
  color: #FF6D04;
  font-family: "verdana";
  font-size: 0.75rem;
  margin: 40px auto 0 auto;
  padding: 20px;
  text-transform: uppercase;
  height: 50px;
}

.form {
  display: inline;
}

.third {
  height: 100%;
  float: right;
  text-align: center;
}

input {
  display: inline;
}

#fonts {
  margin-left: 4px;
}

#weight {
}

/*
Web Safe Font Preview
While there are many fonts you can purchase and add to your site, there are also several free, web safe fonts that work across all browsers. Your company wants you to build a simple app to preview different web safe fonts, sizes, and weights. With jQuery, it’s a snap!

If you get stuck during this project or would like to see an experienced developer work through it, click “Get Help“ to see a project walkthrough video.

Tasks
9/10 Complete
Mark the tasks as complete by checking them off
1.
To begin, look at index.html:

There are three fields in the <form>, two <select> menus, and an <input>. We will target each of these fields by its id.

There is also a <textarea> where the user will enter the text to preview. We can also target this field by id.

We will use the keyup event handler to update the preview text, so we don’t need a submit button.

Now navigate to main.js to start coding.

2.
In the main function in main.js, add a keyup event handler to '#text'. Make sure it takes a parameter: event.

￼
Stuck? Get a hint
3.
In the keyup callback function, call the html method on the '.preview' element and pass it the current value of $(event.currentTarget), the updated input field, by using the .val() method.

Then test that entered text is being added to the preview after each keystroke.

￼
Stuck? Get a hint
4.
Under the keyup method, attach a change event handler to the <select> field with an id of "font".

The change event handler will fire anytime the selected value of the '#font' menu changes.

￼
Stuck? Get a hint
5.
In the callback function of the change event handler, use the css method to change the value of the '.preview' element’s font-family property to the current value of this menu.

Now test your app to see that the font of the preview text changes when you select a different font.

￼
Stuck? Get a hint
6.
Now add another change event handler, this time to the weight menu.

Just like in the last task, have the callback function set the preview element’s font-weight property to the current value of this menu.

Test that the font-weight changes.

￼
Stuck? Get a hint
7.
Since the font-size input field requires text to be entered, we’ll use a keyup event handler to change the font-weight of the preview text.

Add a keyup event handler to the font-size field.

￼
Stuck? Get a hint
8.
In the callback function of the keyup event handler, create a variable called fontSize. Set it to the current value of this field, and use the + operator to add 'px'. We do this because we will need to specify the unit for the CSS font-size property in the next step.

￼
Stuck? Get a hint
9.
Change the font-size property of the preview text to the value stored in fontSize.

￼
Stuck? Get a hint
10.
Now give it a try! You can now easily preview font sizes, families, and weights to determine the right combinations.

And you could go even further! You can see list of web-safe fonts here. Feel free to add them to your <select> menu to make your app even more comprehensive!
*/

/*

TRAVERSING THE DOM
Children
According to the DOM tree, the outermost element is the parent of all elements inside of it. Therefore, the HTML elements inside of the outer element are children. The jQuery .children() method allows us to target these elements.

<div class='parent' id='holder'>
  <div>Child <span>1</span></div>
  <div>Child <span>2</span></div>
  <div>Child <span>3</span></div>
</div>
const $kids = $('#holder').children();
$kids.on('click', event => {
  $(event.currentTarget).css('border', '1px solid black');
});
In the example above, the $kids variable refers to all children of the element with id 'holder' (the divs inside '#holder'). The .on() method adds the click event handler to these $kids. When one of them is clicked, jQuery will add a border around it that is 1px wide and solid black.

It is important to note that only the direct descendants of '#holder' are considered children. Any elements inside the child elements of '#holder', such as the <span> elements, will not be targeted by the .children() method.

Within the click event handler on the '.shoe-details li' selector, target the children of the '.shoe-details' elements.

Use .removeClass() to remove the 'disabled' class from the targeted children.

When you select a shoe size, this jQuery activates the ADD TO CART button.

*/

//

$(document).ready(() => {
  
  $('.shoe-details').show();
  
  $('.more-details-button').on('click', event => {
    
  });  
  
  $('.shoe-details li').on('click', event => {
    $(event.currentTarget).addClass('active');
    $(event.currentTarget).siblings().removeClass('active')
    $('.shoe-details').children().removeClass('disabled');
  });
  
//$('.shoe-details').children().removeClass('disabled');  
  
  ///////////////////////////////////////////
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
    $('.login-button').toggleClass('button-active');
  });

  $('.product-photo').on('mouseenter', () => {
    $(this).addClass('photo-active');
  }).on('mouseleave', function() {
    $(this).removeClass('photo-active');
  });

  $('.menu-button').on('click', () => {
    $('.menu-button').toggleClass('button-active');
    $('.nav-menu').toggleClass('hide');
  });
})

/*
TRAVERSING THE DOM
Parent & Siblings
In addition to the .children() method we covered in the last exercise, there are two methods you can use to select the parent and siblings of an element.

$('.choice').on('click', event => {
  $(event.currentTarget).parent().hide();
});
In the example above, the .parent() method targets the parent element of '.choice' elements and removes it from the DOM.

$('.choice').on('click', event => {
  $(this).siblings().removeClass('selected');
  $(event.currentTarget).addClass('selected');
});
In the code above, the .siblings() method targets elements adjacent to the clicked '.choice' and removes the 'selected' class from any previously clicked '.choice's. Then the 'selected' class is added only to the clicked '.choice'.

1.
Now, click on multiple shoe sizes for one shoe and notice that they all light up. In order to remove the active class from all of the other shoe sizes, you can utilize .siblings().

Write another selector for the shoe size selected using $(event.currentTarget). Then, select all of its siblings with .siblings().

￼
Stuck? Get a hint
2.
Use the .removeClass() method to remove the active class from all of the current target’s siblings. You can chain .removeClass() directly onto the .siblings() method.

*/

//

$(document).ready(() => {
  
  $('.shoe-details').show();
  
  $('.more-details-button').on('click', event => {
   
  });  
  
  $('.shoe-details li').on('click', event => {
    $(event.currentTarget).siblings().removeClass('active');
    $(event.currentTarget).addClass('active');
  });
  
  // (event.currentTarget).siblings().removeClass('active');
  
  ///////////////////////////////////////////
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
    $('.login-button').toggleClass('button-active');
  });

  $('.product-photo').on('mouseenter', () => {
    $(this).addClass('photo-active');
  }).on('mouseleave', function() {
    $(this).removeClass('photo-active');
  });

  $('.menu-button').on('click', () => {
    $('.menu-button').toggleClass('button-active');
    $('.nav-menu').toggleClass('hide');
  });
})

/*
Closest
To select an element close to the current element, we can use jQuery’s .closest() method.

The .closest() method will travel up the DOM tree to find a specified selector closest to it. Its syntax looks like:

$('.example-class-one').closest('.another-class');
In the example above:

The .closest() method is called on '.example-class' elements.
The method then targets the element selected by the .closest() method with a class of '.another-class'.
<div class='.another-class'>
  <p class='.example-class-one'>1</p>
</div>
<div class='.another-class'>
  <p class='.example-class-two'>2</p>
</div>
Given this HTML, the jQuery above would select the <div> element that wraps the paragraph with a value of 1, because it is the closest element, up the DOM tree, with the class .another-class.

Instructions
1.
In the Children exercise, you removed the 'disabled' class from all '.shoe-details' elements when a user clicked a size. When you did that, it activated the ADD TO CART button in every product details card.

Use the .closest() method to activate only the current product details ADD TO CART button.

Inside of the '.shoe-details li' click event handler, create a jQuery object with the current element and use .closest() to target the nearest '.shoe-details' element.

￼
Stuck? Get a hint
2.
Now that you’ve targeted the current '.shoe-details' card, use the .children() and .removeClass() methods to activate the current ADD TO CART button (remove the 'disabled' class).

￼
Stuck? Get a hint
3.
Next, we need to use the .closest() method to target the nearest shoe details element when a user selects a .more-details-button element.

Inside the '.more-details-button' click event handler’s callback function, write another $(event.currentTarget) selector. Then, call the .closest() method on it, and find the closest element with a class of '.product-details'.

In the next exercise, we will chain a .next() method to this.
*/

//
$(document).ready(() => {
  
  $('.shoe-details').show();
  
  $('.more-details-button').on('click', event => {
   $(event.currentTarget).closest('.product-details')
  });  
  
  $('.shoe-details li').on('click', event => {
    $(event.currentTarget).siblings().removeClass('active');
    $(event.currentTarget).addClass('active');
    $(event.currentTarget).closest('.shoe-details').children().removeClass('disabled');
  });
  
  //$(event.currentTarget).closest('.shoe-details').children().removeClass('disabled');
  //$(event.currentTarget).closest('.product-details')
  
  ///////////////////////////////////////////
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
    $('.login-button').toggleClass('button-active');
  });

  $('.product-photo').on('mouseenter', () => {
    $(this).addClass('photo-active');
  }).on('mouseleave', function() {
    $(this).removeClass('photo-active');
  });

  $('.menu-button').on('click', () => {
    $('.menu-button').toggleClass('button-active');
    $('.nav-menu').toggleClass('hide');
  });
})

/*

Next
Sometimes you don’t want to target all the siblings of an element — you just want to target the next one. That’s where the aptly-named .next() method comes in!

The code below is HTML for a menu. The list of food types is hidden, <ol style='display:none'>.

<div class='heading'>MENU</div>
<ol style='display: none'>
  <li>Appetizers</li>
  <li>Entrees</li>
  <li>Salads</li>
  <li>Sides</li>
  <li>Desserts</li>
</ol>
Since the div and <ol> exist on the same level of the DOM, they are siblings. Since there are no elements between them, the <ol> is the next sibling of '.heading'. We can add an event handler to the div element and use the .next() method to show and hide the <ol> using the .toggle() method.

const $heading = $('.heading');
$heading.on('click', () => {
  $(event.currentTarget).next().toggle();
});
In the example above, the .on() method attaches the click event handler to $heading. Then the callback function will toggle the class of the $heading‘s next sibling, the ol element.

It’s important to note that jQuery also has a method called .prev() that can look at the previous sibling.

Instructions
1.
To get the '.shoe-details' element to display when clicking the '.more-details-button', you need to select the element next after the '.product-details' element.

In a previous exercise, you used .closest() to select '.product-details'.

Now, chain a .next() method on the .closest() method to select the '.shoe-details' element.

￼
Stuck? Get a hint
2.
Now that you have the '.shoe-details' selected with logical selectors, chain the .toggle() method on the .next() method you just wrote, so that when clicking the more details button, the '.shoe-details' section becomes visible.

*/
(event.currentTarget).closest('.product-details')
//to ...
(event.currentTarget).closest('.product-details').next().toggle();

/*

find
Sometimes we want to target an element that lives inside another, but we don’t want to use the .children() method, since that might target more elements than we need. That’s where the .find() method comes in. This method finds and targets singular or multiple elements that are descendants of an element. Unlike the .children() method, it traverses all descendants of the specified element, not just the first level down.

const $items = $('.myList').find('li');
The .find() method takes a parameter that specifies how to filter results. This parameter is just like anything you might use to select a jQuery object, ('#id', '.class', tag, etc.). .find() will return all descendants that match the passed in selector. In the example above, the .find() method will return all <li> child elements inside the '.myList' element.

Instructions
1.
Let’s use .find() to make the arrow in the .more-details-button rotate when it is selected.

Inside of the .more-details-button click event, create a jQuery object with the current element ($(event.currentTarget)).

Use the .find() method to find the img inside the current element.

￼
Stuck? Get a hint
2.
Chain a .toggleClass() method to .find() and add or remove the 'rotate' class.
*/

//(event.currentTarget).find('img').toggleClass('rotate');

//main.js

$(document).ready(() => {
  
  $('.more-details-button').on('click', event => {
    $(event.currentTarget).closest('.product-details').next().toggle();
    $(event.currentTarget).find('img').toggleClass('rotate');
  });  
  
  $('.shoe-details li').on('click', event => {
    $(event.currentTarget).addClass('active');
    
    $(event.currentTarget).siblings().removeClass('active')
    
    $(event.currentTarget).closest('.shoe-details').children().removeClass('disabled')
    
    
  });
  
  
  
  ///////////////////////////////////////////
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
    $('.login-button').toggleClass('button-active');
  });

  $('.product-photo').on('mouseenter', () => {
    $(this).addClass('photo-active');
  }).on('mouseleave', function() {
    $(this).removeClass('photo-active');
  });

  $('.menu-button').on('click', () => {
    $('.menu-button').toggleClass('button-active');
    $('.nav-menu').toggleClass('hide');
  });
})

// index.html

<!DOCTYPE html>
<html>

<head>
  <title>Sole Shoes</title>
  <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,700' rel='stylesheet'>
  <link href='https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700' rel='stylesheet'>
  <link rel='stylesheet' type='text/css' href='css/styles.css'>
</head>

<body>

  <!-- Navigation -->
  <nav>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>
        <span class='menu-button'>Menu</span>
        <span class='login-button'>Login</span>
      </div>
    </div>
  </nav>

  <!-- Nav Menu -->
  <div class='nav-menu hide'>
    <div class='container'>
      <ul>
        <li>Shoes</li>
        <li>Women's Shoes</li>
        <li>Men's Shoes</li>
        <li>Shoe Accessories</li>
        <li>Wholesale</li>
      </ul>
      <ul>
        <li>Contact</li>
        <li>Twitter</li>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>Email</li>
      </ul>
    </div>
  </div>

  <!-- Login Form -->
  <div class='login-form'>
    <div class='container'>
      <form>
        <h4>Username</h4>
        <input class='username' />
        <h4>Password</h4>
        <input type='password' />
        <input class='sign-in-button' type='submit' value='Sign In' />
      </form>
    </div>
  </div>

  <!-- Product Cards -->
  <div class='container'>
    <div class='product-card'>
      <div class='product-photo sole-air-ii'></div>
      <div class='product-details'>
        <h4>Sole Air II</h4>
        <div>
          <p>$35</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The ultimate in style and comfort, the Sole Air II's are great for walking and casual wearing.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>8</li>
            <li>9</li>
            <li>10</li>
            <li>11</li>
            <li>12</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo tidal-x'></div>
      <div class='product-details'>
        <h4>Tidal X</h4>
        <div>
          <p>$40</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>The Tidal X's signature rubber midsole make this the perfect running shoe. With a soft mesh upper, and synthetic polymer outsole, these shoes really fly.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>6</li>
            <li>7</li>
            <li>10</li>
            <li>12</li>
            <li>13</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>

    </div>
  </div>

  <div class='container'>
    <div class='product-card'>
      <div class='product-photo dark-sole-original'></div>
      <div class='product-details'>
        <h4>Dark Sole Original</h4>
        <div>
          <p>$60</p>
          <div class='more-details-button'>
            <img src='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/right-arrow.svg' />
          </div>
        </div>
      </div>

      <div class='shoe-details'>
        <p>Light up the night with the Dark Sole Original. Lights around the midsole activate when stomped.</p>
        <div class='size-chart'>
          <h4>Size</h4>
          <ul class='sizes'>
            <li>9</li>
            <li>10</li>
            <li>10.5</li>
            <li>11</li>
          </ul>
        </div>
        <div class='buy-now-button disabled'>
          <h3>Add to cart</h3>
        </div>
      </div>
    </div>
  </div>

  <!-- Shopping cart -->
  <div class='shopping-cart'>
    <div class='container'>
      <div class='cart'>
        <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/shopping-cart.svg'></object>
        <h3 class='items-qty'>1</h3>
      </div>
      <h3>Checkout</h3>
    </div>
  </div>

  <footer>
    <div class='container'>
      <object type='image/svg+xml' data='https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-logo.svg'></object>
      <div>Contact Us</div>
    </div>
  </footer>

   <script
  src="https://code.jquery.com/jquery-3.2.1.min.js"
  integrity="sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4="
  crossorigin="anonymous"></script>


  <script src='js/main.js'></script> 
</body>

</html>


//styles.css

* {
  margin: 0;
  padding: 0;
  transition: 0.1s; }

body {
  font-family: 'Roboto Condensed', Helvetica, sans-serif;
  text-align: left;
  font-size: 18px;
  color: #303030; }

.container {
  max-width: 450px;
  margin: 0 auto; }

h3 {
  color: #C3FF00;
  font-weight: 700;
  text-transform: uppercase;
  letter-spacing: 0.1em; }

h4 {
  text-transform: uppercase; }

.disabled h3 {
  color: #535353;
  cursor: not-allowed; }

.button-active {
  color: #C3FF00;
  background-color: #535353; }

nav {
  background-color: #303030;
  color: #EFEFEF; }
  nav .container {
    display: flex;
    justify-content: space-between;
    align-items: center; }
    nav .container object {
      width: 4.5em;
      padding: 1.2em 0.5em; }
    nav .container .login-button,
    nav .container .menu-button {
      text-transform: uppercase;
      letter-spacing: 0.1em;
      padding: 1em 1.25em;
      -webkit-user-select: none;
      -moz-user-select: none;
      -ms-user-select: none;
      user-select: none;
      cursor: pointer; }

.nav-menu {
  background-color: #535353;
  color: #EFEFEF;
  display: flex;
  justify-content: center; }
  .nav-menu .container {
    padding: 1.5em;
    display: flex; }
    .nav-menu .container ul {
      list-style: none; }
      .nav-menu .container ul li {
        padding: 0.25em 2em; }
        .nav-menu .container ul li:first-child {
          text-transform: uppercase;
          color: #C3FF00;
          letter-spacing: 0.05em; }

.hide {
  display: none; }

.login-form {
  background-color: #535353;
  padding: 1em 0 0;
  color: #EFEFEF;
  display: none; }
  .login-form .container {
    padding: 0 0.5em; }
  .login-form h4 {
    font-weight: 400; }
  .login-form input {
    width: calc(100% - 1em);
    border: none;
    height: 2em;
    margin: 0.5em 0;
    font-size: 1em;
    padding: 0 0.5em; }
  .login-form .sign-in-button {
    background-color: #303030;
    color: #C3FF00;
    font-weight: 700;
    text-transform: uppercase;
    letter-spacing: 0.1em;
    text-align: center;
    width: 100%;
    height: 2.5em;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    cursor: pointer; }

.product-card {
  margin: 1em 0; }
  .product-card .dark-sole-original,
  .product-card .sole-air-ii,
  .product-card .tidal-x {
    background-size: 28em 15em;
    background-position: center;
    height: 14em;
    transition: 0.2s; }
  .product-card .sole-air-ii {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/sole-air-ii.png"); }
  .product-card .tidal-x {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/tidal-x.png"); }
  .product-card .dark-sole-original {
    background-image: url("https://s3.amazonaws.com/codecademy-content/courses/jquery/audit/images/dark-sole-original.png"); }
  .product-card .photo-active {
    background-size: 30.8em 16.5em;
    transition: 0.2s; }
  .product-card .product-details {
    margin-top: -5px;
    background-color: #EFEFEF;
    display: flex;
    justify-content: space-between; }
    .product-card .product-details h4,
    .product-card .product-details p {
      padding: 0.7em 1.25em; }
    .product-card .product-details div {
      display: flex; }
    .product-card .product-details .more-details-button {
      background-color: #535353;
      padding: 0.75em 1.25em;
      cursor: pointer;
      width: 1em;
      transition: 0.1s; }
      .product-card .product-details .more-details-button img {
        position: relative;
        left: 0.1em; }
      .product-card .product-details .more-details-button .rotate {
        transition: 0.1s;
        transform: rotate(90deg); }
  .product-card .shoe-details {
    display: none;
    background-color: #535353;
    color: #EFEFEF; }
    .product-card .shoe-details .active {
      background-color: #C3FF00;
      color: #303030; }
  .product-card .size-chart,
  .product-card p {
    padding: 1em 1.25em; }
    .product-card .size-chart ul,
    .product-card p ul {
      list-style: none;
      display: flex;
      justify-content: space-around;
      margin-top: 1em; }
      .product-card .size-chart ul li,
      .product-card p ul li {
        padding: 0.5em;
        background-color: #303030;
        width: 100%;
        text-align: center;
        margin-right: 2px; }
  .product-card .buy-now-button {
    background-color: #303030;
    text-align: center;
    padding: 0.75em;
    cursor: pointer; }

.shopping-cart {
  background-color: #171717;
  position: fixed;
  bottom: 0;
  z-index: 99;
  width: 100%;
  box-shadow: 2px 0 4px 0 rgba(0, 0, 0, 0.5);
  display: none;
  height: 3.5em; }
  .shopping-cart .container {
    display: flex;
    justify-content: space-between;
    padding: 1em; }
    .shopping-cart .container .cart {
      display: flex; }
      .shopping-cart .container .cart object {
        margin-right: 0.75em; }

footer {
  color: #EFEFEF;
  background-color: #303030;
  margin-top: 2em;
  padding: 2em 0.5em; }
  footer .container {
    display: flex;
    justify-content: space-between; }
    footer .container object {
      width: 4.5em; }
/*

Review: Traversing the DOM
Understanding how elements relate to each other in the DOM makes it easy to efficiently select elements. We have covered several methods in this lesson including:

.children() to target an element’s child elements.
.siblings() to target elements adjacent to an element.
.parent() to target an element’s parent.
.closest() travels up the DOM tree from the current element to target the closest element with a given selector.
.next() to target the element immediately following the selected element.
.prev() to target the element that is immediately preceding the selected element.
.find() to target descendant elements by some selector, ie- class, id, tag etc.
In addition to these methods, there are even more, including .prevUntil(), .nextUntil() and others. To get an idea, check out Mozilla Developer Network reference for jQuery Traversing.

*/

//review main.js

$(document).ready(() => {
  
  $('.shoe-details').show();
  
  $('.more-details-button').on('click', event => {
   $(event.currentTarget).closest('.product-details').next().toggle();
  });  
  
  $('.shoe-details li').on('click', event => {
    $(event.currentTarget).siblings().removeClass('active');
    $(event.currentTarget).addClass('active');
    $(event.currentTarget).closest('.shoe-details').children().removeClass('disabled');
  });
  
  
  
  ///////////////////////////////////////////
  $('.login-button').on('click', () => {
    $('.login-form').toggle();
    $('.login-button').toggleClass('button-active');
  });

  $('.product-photo').on('mouseenter', () => {
    $(this).addClass('photo-active');
  }).on('mouseleave', function() {
    $(this).removeClass('photo-active');
  });

  $('.menu-button').on('click', () => {
    $('.menu-button').toggleClass('button-active');
    $('.nav-menu').toggleClass('hide');
  });
})

//gameboard

/*
Gameboard
Gameboard is creating a scoreboard that displays NBA scores from around the league. They want the user to be able to click the More link to see the dropdown menu, to click the Share link to see the share menu, and to click the notification bell.

If you get stuck during this project or would like to see an experienced developer work through it, click “Get Help“ to see a project walkthrough video.

Tasks
4/5 Complete
Mark the tasks as complete by checking them off
1.
Look at index.html:

In the <div class="row more">, there are two elements: an <a class="more-btn"> and a <ul class="more-menu">. When the <a> is clicked, we want the <ul class="more-menu"> to appear.

Inside the <ul class="more-menu">, there are two elements: an <li class="share"> and a <li class="share-menu">. When the <li class="share"> is clicked, we want the <li class="share-menu"> to appear.

There is a <span class="notification"> element. When that element is clicked, we want the notification bell to turn yellow.

2.
In script.js, attach a click event handler to the <a class="more-btn"> element.

When clicked, toggle the sibling <ul class="more-menu"> element.

￼
Stuck? Get a hint
3.
Attach a click event handler to the <li class="share"> element. When clicked, toggle the corresponding <li class="share-menu"> element.

￼
Stuck? Get a hint
4.
Attach a click event handler to the notification bell. When clicked, toggle the class active.

5.
Click here for a video walkthrough from our experts to help you check your work!*/

//script.js

var main = function() {
  $('.more-btn').on('click', event => {
    //$(event.currentTarget).siblings('more-menu').toggle();
    $(event.currentTarget).siblings().toggleClass('more-menu');
  });
  
  $('.share').on('click', event => {
    $(event.currentTarget).next().toggle();
    //$(event.currentTarget).siblings().toggle();
  });

  $('.notification').on('click', event => { 
    $(event.currentTarget).toggleClass('active');
  });

/*
  $('.bell').on('click', event => { 
    $(event.currentTarget).children().toggleClass('active');
  });
                <span class="notification glyphicon glyphicon-bell"></span>
*/
};

$(document).ready(main);

//styles.css

html, body {
  margin: 0;
  padding: 0;
}

body {
  background-color: #1f1f1f;
  color: #fff;
  font-family: 'Roboto', sans-serif;
}

.container {
  max-width: 980px;
}

.container .row .col-sm-4 {
  margin: 0 0 30px;
}

.col-xs-4 {
  width: 37.5%;
}

.col-xs-4, .col-xs-3 {
  padding: 0;
}

a, 
li,
.share-menu span:hover {
  color: #00ffbc;
  cursor: pointer;
}

a:hover,
li:hover {
  color: #e2e2e2;
  text-decoration: none;
}


/* Header */
.header {
  background: #000;
  margin: 0 0 40px;
}

.header h1 {
  font-family: 'Oswald', sans-serif;
  font-size: 24px;
  letter-spacing: 0.5em;
  margin: 0;
  padding: 40px 0;
  text-align: center;
  text-transform: uppercase;
}

/* Scorecard row */
.scorecard,
.more {
  background: rgba(255,255,255,0.1);
  border-bottom: 1px solid rgba(0,0,0,0.25);
  border-top: 1px solid rgba(255,255,255,0.1);
  box-shadow: 0 2px 10px rgba(0,0,0,0.1);
  margin: 0 1px 0;
  padding: 10px 15px;
}

.scorecard p {
  font-weight: 100;
  text-align:center;
  text-transform: uppercase;
}

.scorecard div h2 {
  color: #00ffbc;
  font-family: 'Oswald', sans-serif;
  font-size: 60px;
  margin: 0;
}

.scorecard .dash h2 {
  color: #fff;
  text-align: center;
}

.scorecard div h3 {
  font-size: 18px;
  font-weight: 100;
  margin: 10px 0;
}

.scorecard .home {
  text-align: right;
}

/* More row */
.more {
  position: relative;
}

.more-btn-container {
  display: inline-block;
  width: 90%;
}

.more-menu {
  display: none;
  margin: 0;
  padding: 0;
}

.more-menu li {
  display: inline-block;
  font-size: 12px;
  list-style: none;
  margin: 0;
  padding: 0 12px 0 0;
}

.bell {
  cursor: pointer;
  display: inline-block;
  position: absolute;
  text-align: right;
  top: 12px;
  width: 8%;
}

li.share-menu {
  display: none;
}

.share-menu span {
  color: #fff;
  margin: 0 10px 0 0;
}

.notification.active { 
  color: #ffd400;
  text-shadow: 0 0 10px #ffd400;
} 

//index.html

<!doctype html>
<html>
  <head>
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,100,300' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'>
    <link href="https://s3.amazonaws.com/codecademy-content/projects/bootstrap.min.css" rel="stylesheet">
  <link rel='stylesheet' href='style.css'/>
  </head>
  <body>
        <div class="header">
      <h1 class="logo">GameBoard</h1>
    </div>

    <div class="main">
      <div class="container">
        <div class="row">
          <div class="col-sm-4">
            <div class="row scorecard">
              <p>Final</p>
              <div class="visitor col-xs-4">
                <h2>97</h2>
                <h3>Phoenix<br/>
                Suns</h3>
              </div>
              <div class="dash col-xs-3">
                <h2>-</h2>
              </div>
              <div class="home col-xs-4">
                <h2>122</h2>
                <h3>Denver<br/>
                Nuggets</h3>
              </div>
            </div>
            <div class="row more">
              <div class="more-btn-container">
                <a class="more-btn" href="#">More</a>
                <ul class="more-menu">
                  <li>Stats</li>
                  <li class="share">Share</li>
                  <li class="share-menu">
                    <span>Facebook</span>
                    <span>Google+</span>
                    <span>Twitter</span>
                  </li>
                </ul>
              </div>
              <div class="bell">
                <span class="notification glyphicon glyphicon-bell"></span>
              </div>
            </div>
          </div>

          <div class="col-sm-4">
            <div class="row scorecard">
              <p>Final</p>
              <div class="visitor col-xs-4">
                <h2>83</h2>
                <h3>Orlando<br/>
                Magic</h3>
              </div>
              <div class="dash col-xs-3">
                <h2>-</h2>
              </div>
              <div class="home col-xs-4">
                <h2>98</h2>
                <h3>Indiana<br/>
                Pacers</h3>
              </div>
            </div>
            <div class="row more">
              <div class="more-btn-container">
                <a class="more-btn" href="#">More</a>
                <ul class="more-menu">
                  <li>Stats</li>
                  <li class="share">Share</li>
                  <li class="share-menu">
                    <span>Facebook</span>
                    <span>Google+</span>
                    <span>Twitter</span>
                  </li>
                </ul>
              </div>
              <div class="bell">
                <span class="notification glyphicon glyphicon-bell"></span>
              </div>
            </div>
          </div>

          <div class="col-sm-4">
            <div class="row scorecard">
              <p>Final</p>
              <div class="visitor col-xs-4">
                <h2>78</h2>
                <h3>New York<br/>
                Knicks</h3>
              </div>
              <div class="dash col-xs-3">
                <h2>-</h2>
              </div>
              <div class="home col-xs-4">
                <h2>105</h2>
                <h3>OKC<br/>
                Thunder</h3>
              </div>
            </div>
            <div class="row more">
              <div class="more-btn-container">
                <a class="more-btn" href="#">More</a>
                <ul class="more-menu">
                  <li>Stats</li>
                  <li class="share">Share</li>
                  <li class="share-menu">
                    <span>Facebook</span>
                    <span>Google+</span>
                    <span>Twitter</span>
                  </li>
                </ul>
              </div>
              <div class="bell">
                <span class="notification glyphicon glyphicon-bell"></span>
              </div>
            </div>
          </div>
        </div>


        <div class="row">
          <div class="col-sm-4">
            <div class="row scorecard">
              <p>Final</p>
              <div class="visitor col-xs-4">
                <h2>102</h2>
                <h3>LA<br/>
                Clippers</h3>
              </div>
              <div class="dash col-xs-3">
                <h2>-</h2>
              </div>
              <div class="home col-xs-4">
                <h2>85</h2>
                <h3>Houston<br/>
                Rockets</h3>
              </div>
            </div>
            <div class="row more">
              <div class="more-btn-container">
                <a class="more-btn" href="#">More</a>
                <ul class="more-menu">
                  <li>Stats</li>
                  <li class="share">Share</li>
                  <li class="share-menu">
                    <span>Facebook</span>
                    <span>Google+</span>
                    <span>Twitter</span>
                  </li>
                </ul>
              </div>
              <div class="bell">
                <span class="notification glyphicon glyphicon-bell"></span>
              </div>
            </div>
          </div>

          <div class="col-sm-4">
            <div class="row scorecard">
              <p>Final</p>
              <div class="visitor col-xs-4">
                <h2>104</h2>
                <h3>Milwaukee <br/>
                Bucks</h3>
              </div>
              <div class="dash col-xs-3">
                <h2>-</h2>
              </div>
              <div class="home col-xs-4">
                <h2>88</h2>
                <h3>Detroit<br/>
                Pistons</h3>
              </div>
            </div>
            <div class="row more">
              <div class="more-btn-container">
                <a class="more-btn" href="#">More</a>
                <ul class="more-menu">
                  <li>Stats</li>
                  <li class="share">Share</li>
                  <li class="share-menu">
                    <span>Facebook</span>
                    <span>Google+</span>
                    <span>Twitter</span>
                  </li>
                </ul>
              </div>
              <div class="bell">
                <span class="notification glyphicon glyphicon-bell"></span>
              </div>
            </div>
          </div>

          <div class="col-sm-4">
            <div class="row scorecard">
              <p>Final</p>
              <div class="visitor col-xs-4">
                <h2>91</h2>
                <h3>NO<br/>
                Pelicans</h3>
              </div>
              <div class="dash col-xs-3">
                <h2>-</h2>
              </div>
              <div class="home col-xs-4">
                <h2>100</h2>
                <h3>Atlanta<br/>
                Hawks</h3>
              </div>
            </div>
            <div class="row more">
              <div class="more-btn-container">
                <a class="more-btn" href="#">More</a>
                <ul class="more-menu">
                  <li>Stats</li>
                  <li class="share">Share</li>
                  <li class="share-menu">
                    <span>Facebook</span>
                    <span>Google+</span>
                    <span>Twitter</span>
                  </li>
                </ul>
              </div>
              <div class="bell">
                <span class="notification glyphicon glyphicon-bell"></span>
              </div>
            </div>
          </div>
        </div>

      </div>
    </div>
    
    <script src="https://s3.amazonaws.com/codecademy-content/projects/jquery.min.js"></script>
    <script src='script.js'></script>
  </body>
</html>


//expert solution

var main = function() {
  $('.more-btn').on('click', event => {
    $(event.currentTarget).siblings('more-menu').toggle();
  });
  
  $('.share').on('click', event => {
    $(event.currentTarget).next().toggle();
  });

  $('.notification').on('click', event => { 
    $(event.currentTarget).toggleClass('active');
  });
};

$(document).ready(main);
