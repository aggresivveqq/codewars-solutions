def sum_array(arr):
    if arr is None or len(arr) <= 2:
        return 0
    
    arr_sorted = sorted(arr)
    return sum(arr_sorted[1:-1]) 
