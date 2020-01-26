#!/usr/bin/env python
import flask
from flask import request, jsonify
from random import random

app = flask.Flask(__name__)
app.config['DEBUG'] = True

@app.route('/', methods=['GET'])
def home():
    return "Get prediction for parking lot capacity as a function of lot latitude, longitude and distance from user"

@app.route('/api/v1/prediction/params/', methods=['GET'])
def prediction():
    
    return jsonify(
        latitude = request.args['lat'],
        longitude = request.args['long'],
        distance =  request.args['dist'],
        statusIn15 = random() <= 0.5,
        statusIn30 = random() <= 0.5,
        statusIn45 = random() <= 0.5
    )

if __name__ == "__main__":
    app.run()