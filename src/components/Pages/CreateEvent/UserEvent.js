import React, { Component } from "react";
import { Link } from "react-router-dom";
import {
  Card,
  CardImg,
  CardText,
  CardTitle,
  CardSubtitle,
  Button,
  Row,
  Col,
  Container,
} from "reactstrap";

const UserEvent = ({ events, deleteEvent }) => {
  return (
    <div className="event-list">
      {events.map((event) => {
        return (
          <div>
            <Container>
              <Row>
                <Col md={4}>
                  <div>
                    <CardImg
                      top
                      width="100%"
                      src={event.imagePreviewUrl}
                      alt={event.headerTitle}
                      className="card-img-top"
                    />
                    <Card body>
                      <CardTitle>
                        <h3 className="card-title text-uppercase">
                          Event Name:
                          {event.headerTitle}
                        </h3>
                      </CardTitle>
                      <CardSubtitle>
                        <h5 className="card-title ">
                          SubHeading:{event.headerSubTitle}
                        </h5>
                      </CardSubtitle>
                    </Card>
                    <Card body inverse color="primary">
                      <CardTitle>Venu:{event.place}</CardTitle>
                      <CardText>Time:{event.time}</CardText>
                      <CardText>Date:{event.date}</CardText>
                      <CardText className=" text-success">
                        Description:{event.headerText}
                      </CardText>
                      <Button
                        onClick={() => {
                          deleteEvent(event.id);
                        }}
                      >
                        {" "}
                        Delete
                      </Button>
                    </Card>
                  </div>
                </Col>
              </Row>
            </Container>
          </div>
        );
      })}
    </div>
  );
};
export default UserEvent;
