$('.form').find('input, textarea').on('keyup blur focus', function (e) {

  var $this = $(this),
      label = $this.prev('label');
   
	  if (e.type === 'keyup') {
			if ($this.val() === '') {
          label.removeClass('active highlight');
        } else {
          label.addClass('active highlight');
        }
    } else if (e.type === 'blur') {
    	if( $this.val() === '' ) {
    		label.removeClass('active highlight'); 
			} else {
		    label.removeClass('highlight');   
			}   
    } else if (e.type === 'focus') {
      
      if( $this.val() === '' ) {
    		label.removeClass('highlight'); 
			} 
      else if( $this.val() !== '' ) {
		    label.addClass('highlight');
			}
    }

});


function validate() {

    var password = $("#password").val();
    var confirmPassword = $("#passwordRe").val();

    if (password != confirmPassword) {
        document.getElementById("passwordRe").value = "";
        document.getElementById("lblPasswordRe").innerHTML = "Passwords didn't match";
    }

}