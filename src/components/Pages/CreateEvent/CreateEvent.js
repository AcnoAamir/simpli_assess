import React, { Component } from "react";
import UserEvent from "./UserEvent";
import { Link } from "react-router-dom";
import AddEvent from "./AddEvent";
import {
  UncontrolledCollapse,
  Button,
  CardBody,
  Card,
  Row,
  Col,
} from "reactstrap";

class App extends Component {
  state = {
    events: [],
  };
  addEvent = (event) => {
    event.id = Math.random();

    let events = [...this.state.events, event];

    this.setState({
      events: events,
    });
  };
  deleteEvent = (id) => {
    // console.log(id);
    let events = this.state.events.filter((event) => {
      return event.id !== id;
    });
    this.setState({
      events: events,
    });
  };
  render() {
    return (
      <div className="App">
        <div>
          <div class="jumbotron jumbotron-fluid">
            <div class="container">
              <h1 class="display-4">
                Host Your Event Here &nbsp; &nbsp; &nbsp; &nbsp;
                <Button
                  color="primary"
                  id="add"
                  style={{ marginBottom: "1rem" }}
                >
                  AddEvent
                </Button>
              </h1>
              <UncontrolledCollapse toggler="#add">
                <Card>
                  <CardBody>
                    <AddEvent addEvent={this.addEvent} />
                  </CardBody>
                </Card>
              </UncontrolledCollapse>
            </div>
          </div>
        </div>
        <div class="container">
          <h1 class="display-4">My Events</h1>
        </div>

        <UserEvent events={this.state.events} deleteEvent={this.deleteEvent} />
        <hr />
        <br />
        <div class="jumbotron jumbotron-fluid">
          <div class="container">
            <h1 class="display-4"></h1>
          </div>
        </div>
      </div>
    );
  }
}

export default App;
