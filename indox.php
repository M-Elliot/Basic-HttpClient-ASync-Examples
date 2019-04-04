<?php

$TestVariable = $_POST['TestValue'];
if ($TestVariable == NULL || $TestVariable == "")
{		
	echo('Broken Dawg');
}
else
{	
	echo($TestVariable);
}