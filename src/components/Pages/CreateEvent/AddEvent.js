import React, { Component } from "react";
import { Button, Form, FormGroup, Label, Input, Row, Col } from "reactstrap";

class AddEvent extends Component {
  state = {
    headerTitle: null,
    headerSubTitle: null,
    headerText: null,
    selectedFile: null,
    imagePreviewUrl: null,
    place: null,
    time: null,
    date: null,
  };
  handleChange = (e) => {
    this.setState({
      [e.target.id]: e.target.value,
    });
  };
  handleSubmit = (e) => {
    e.preventDefault();
    this.props.addEvent(this.state);
  };
  fileChangedHandler = (event) => {
    this.setState({
      selectedFile: event.target.files[0],
    });

    let reader = new FileReader();

    reader.onloadend = () => {
      this.setState({
        imagePreviewUrl: reader.result,
      });
    };

    reader.readAsDataURL(event.target.files[0]);
  };

  submit = () => {
    var fd = new FormData();

    fd.append("file", this.state.selectedFile);

    var request = new XMLHttpRequest();

    request.onreadystatechange = function () {
      if (this.readyState === 4 && this.status === 200) {
        alert("Uploaded!");
      }
    };
    request.open(
      "POST",
      "https://us-central1-tutorial-e6ea7.cloudfunctions.net/fileUpload",
      true
    );
    request.send(fd);
  };
  render() {
    let $imagePreview = (
      <div className="previewText image-container">
        Please select an Image for Preview
      </div>
    );
    if (this.state.imagePreviewUrl) {
      $imagePreview = (
        <div className="image-container">
          <img src={this.state.imagePreviewUrl} alt="icon" width="200" />{" "}
        </div>
      );
    }
    return (
      <Row>
        <Col sm="12" md={{ size: 18, offset: 4 }}>
          <div>
            <div className="form-wrapper">
              <form onSubmit={this.handleSubmit}>
                <Row form>
                  <Col md={6}>
                    <FormGroup>
                      <Label for="name">Event Title</Label>
                      <Input
                        type="text"
                        id="headerTitle"
                        placeholder="Event Name"
                        onChange={this.handleChange}
                      />
                    </FormGroup>
                  </Col>
                  <Col md={6}>
                    <FormGroup>
                      <Label for="name">Event SubTitle</Label>
                      <Input
                        type="text"
                        id="headerSubTitle"
                        placeholder="Event SubTitle"
                        onChange={this.handleChange}
                      />
                    </FormGroup>
                  </Col>
                </Row>
                <Row form>
                  <Col md={6}>
                    <FormGroup>
                      <Label for="name">Event Address</Label>
                      <Input
                        type="text"
                        id="place"
                        placeholder="Address"
                        onChange={this.handleChange}
                      />
                    </FormGroup>
                  </Col>
                  <Col md={6}>
                    <FormGroup>
                      <Label for="exampleText">Text Area</Label>
                      <Input
                        type="textarea"
                        name="text"
                        id="headerText"
                        onChange={this.handleChange}
                      />
                    </FormGroup>
                  </Col>
                </Row>
                <Row form>
                  <Col md={6}>
                    <FormGroup>
                      <Label for="exampleDate">Date</Label>
                      <Input
                        type="date"
                        id="date"
                        placeholder="date placeholder"
                        onChange={this.handleChange}
                      />
                    </FormGroup>
                  </Col>
                  <Col md={6}>
                    <FormGroup>
                      <Label for="exampleTime">Time</Label>
                      <Input
                        type="time"
                        name="time"
                        id="time"
                        placeholder="time placeholder"
                        onChange={this.handleChange}
                      />
                    </FormGroup>
                  </Col>
                </Row>
                <FormGroup>
                  <Label for="exampleFile">Event Image</Label>
                  <Input type="file" onChange={this.fileChangedHandler} />

                  <button type="button" onClick={this.submit}>
                    {" "}
                    Upload{" "}
                  </button>
                </FormGroup>

                <div className="createAccount">
                  <button>Submit</button>
                </div>
              </form>
            </div>
          </div>
        </Col>
      </Row>
    );
  }
}

export default AddEvent;
