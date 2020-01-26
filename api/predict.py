
def predict(lat : int, long : int, dist : int):
    return "127.0.0.1:5000/api/v1/prediction/params?lat="+str(lat)+"&long="+str(long)+"&dist="+str(dist)
