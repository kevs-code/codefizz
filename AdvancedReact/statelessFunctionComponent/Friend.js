import React from 'react';
import ReactDOM from 'react-dom';

export const Friend = () => {
	return <img src='https://s3.amazonaws.com/codecademy-content/courses/React/react_photo-octopus.jpg' />;
}

ReactDOM.render(
	<Friend />,
	document.getElementById('app')
);
