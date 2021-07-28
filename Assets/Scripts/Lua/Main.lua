local loginMediator = require( "Logic.Login.LoginMediator")

--//---------------------------------------
function Awake()
    print("Main============= Awake")
end

function Start()
    print("Main============= Start")
    loginMediator:Test()
end

function Update()
    
end

function LateUpdate()
    
end

function OnDestroy()
    
end


