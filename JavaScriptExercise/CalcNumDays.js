<script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>

<script>
            $("#ToDate").change(function () {
                var start = new Date($('#FromDate').val());
                var end = new Date($('#ToDate').val());

               var diff = new Date(end - start);
               var days=1;
                days = diff / 1000 / 60 / 60 / 24;


                if (days == NaN) {
                    $('#TotalDays').val(0);
                } else {
                    $('#TotalDays').val(days+1);
                }
            })
        </script>