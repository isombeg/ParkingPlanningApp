#!/usr/bin/env python
import api, predict
from selenium import webdriver

if __name__ == "__main__":
    queries = []

    queries.append(
        int(input("Enter latitude: "))
    )

    queries.append(
        int(input("Enter longitude: "))
    )

    queries.append(
        int(input("Distance in minutes: "))
    )

    a = predict.predict(
        queries[0],
        queries[1],
        queries[2]
    )

    driver = webdriver.Chrome()
    api.app.run()
    driver.get(a)
