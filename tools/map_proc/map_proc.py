#coding: utf-8

import Image
from ctypes import *
import struct

def proc_one_byte(buf):
    fm = "<B"
    data = struct.unpack(fm, buf[0:1])
    value = 0
    if data[0] < 30 :
        value = 0
    elif data[0] < 80:
        value = 80
    else:
        value = 85
    return value

def save_one_byte(file, data):
    fm = "<B"
    tmp = struct.pack(fm, data)
    file.write(tmp)
 
def proc(filename, saveFile):
    rawFile = open(filename, 'rb')
    saveFile = open(saveFile, 'wb+')
    for i in range(1025 * 1025):
        data = proc_one_byte(rawFile.read(1))
        save_one_byte(saveFile, data)
        
    rawFile.close()
    saveFile.close();

if __name__ == "__main__":
    proc("jiuzhou.raw", "test.raw")