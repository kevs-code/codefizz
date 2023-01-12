const apiKey = 'bxITM1VEAXuqdh4fRMeFjQ_yaq4DNXuAiT-CxjV4bdhKs7qbVEVdNacIx85qVBeilZRGin0mxds2o-priFRwZJvdCl31cbybJCptGimbdXSwxDK5u8t77Noil0b1XnYx'; 
const Yelp = {};
const inputField = document.querySelector('#term');
const topicField = document.querySelector('#location');
const submit = document.querySelector('#submit');
const responseField = document.querySelector('#responseField');

const sortBy = "best_match";
const term = inputField.value;
const location = topicField.value;

const renderJsonResponse = (res) => {
  // creating an empty object to store the JSON in key-value pairs
  let rawJson = {}
  for(let key in response){
    rawJson[key] = response[key]
  }
  // converting JSON into a string and adding line breaks to make it easier to read
  rawJson = JSON.stringify(rawJson).replace(/,/g, ", \n")
  // manipulates responseField to show the returned JSON.
  responseField.innerHTML = `<pre>${rawJson}</pre>`
}


const search = (term, location, sortBy) => {
    return fetch(`https://cors-anywhere.herokuapp.com/https://api.yelp.com/v3/businesses/search?term=${term}&location=${location}&sort_by=${sortBy}`, {
        headers: {
        Authorization: `Bearer ${apiKey}`
        }
    })
    .then(response => {
        return response.json();
    })
    .then(jsonResponse => {
        if (jsonResponse.businesses) {
		renderJsonResponse(jsonResponse.businesses);
		
            /*return jsonResponse.businesses.map(business => 
            {
                id: business.id,
                imageSrc: business.image_url,
                name:
                address:
                city:
                state:
                zipCode:
                category:
                rating:
                reviewCount:
                
            }) */   
        }
    })
};


submit.addEventListener('click',search(term, location, sortBy));
