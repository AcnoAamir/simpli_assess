import React, { Component } from "react";
import { InfoConsumer } from "../Context";
import Info from "../Info";
import { Link } from "react-router-dom";

class Home extends Component {
  render() {
    return (
      <div>
        <div class="jumbotron jumbotron-fluid">
          <div class="container">
            <h1 class="display-4">Ongoing & Upcoming Events</h1>
          </div>
        </div>

        <div className="container">
          <div className="row mt-5">
            <InfoConsumer>
              {(value) => {
                return value.info.map((item) => {
                  return <Info key={item.id} item={item} />;
                });
              }}
            </InfoConsumer>
          </div>
        </div>

        <div class="jumbotron jumbotron-fluid">
          <Link
            className="nav-link  text-white text-uppercase ml-5"
            to="/login"
          >
            <div class="container">
              <h1 class="display-4">
                Host Your Event &nbsp; &nbsp; &nbsp; &nbsp;
                <button type="button" class="btn btn-dark">
                  Create Event
                </button>
              </h1>
            </div>
          </Link>
        </div>
      </div>
    );
  }
}
export default Home;
