import React from 'react'
import ReactDOM from 'react-dom'
import App from '../components/App.jsx'

window.renderPage = (dom, props) => {
    ReactDOM.render(React.createElement(App), dom);
}
