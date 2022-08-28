import React from "react";

import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import Navbar from "./components/Layout/Navbar/Navbar";
import Footer from "./components/Layout/Footer/Footer";
import { Switch, Route } from "react-router-dom";
import Home from "./components/Pages/Home";
import CreateEvent from "./components/Pages/CreateEvent/CreateEvent";
import login from "./components/Pages/login";
import AboutUs from "./components/Pages/About/AboutUs";
import Contacts from "./components/Pages/ContactUs";
import Detalis from "./components/Pages/Details";
import NotFoundPage from "./components/Pages/NotFoundPage";

function App() {
  return (
    <div>
      <Navbar />
      <Switch>
        <Route exact path="/" component={Home} />
        <Route path="/about" component={AboutUs} />
        <Route path="/contacts" component={Contacts} />
        <Route path="/create" component={CreateEvent} />
        <Route path="/details" component={Detalis} />
        <Route path="/login" component={login} />

        <Route component={NotFoundPage} />
      </Switch>
      <Footer />
    </div>
  );
}

export default App;
