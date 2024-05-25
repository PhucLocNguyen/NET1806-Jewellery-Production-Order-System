import { Button } from '@mui/material';
import InputPassword from './InputPassword';
import InputText from './InputText';
import { useRef, useEffect, useState } from 'react';
import { motion, AnimatePresence } from "framer-motion";

function Login() {
    const loginRef = useRef()
    const registerRef = useRef()
    let [isToggle,setIsToggle] = useState(false);

    useEffect(() => {
        console.log(loginRef.current);
    })

    return (
        <div className="bg-[#c9d6ff] w-full h-screen bg-gradient-to-r from-purple-500 to-pink-500 flex items-center justify-center flex-col">
            <div className="bg-[#fff] rounded-[30px] shadow-[0_5px_15px_rgba(0,0,0,0.35)] relative overflow-hidden w-[768px] max-w-[100%] min-h-[480px]">

                <motion.div
                    // initial={false}
                    animate={{
                        x: isToggle ? '100%' : 0,
                        opacity: isToggle ? [0, 1] : 0,
                        zIndex: isToggle ? [1, 5] : 1
                    }}
                    transition={{ duration: 0.6}}
                    className='absolute h-[100%] top-0 transition duration-600 ease-in-out left-0 w-[50%] z-1 opacity-0'
                >
                    <form className='bg-[#fff] flex items-center justify-center flex-col h-[100%] px-[40px]'>
                        <h1>Create Account</h1>
                        <div>

                        </div>
                        <span className="text-[12px]">or use your email for registeration</span>
                        {/* <input type="text" placeholder="Name"></input>
                        <input type="email" placeholder="Email"></input>
                        <input type="password" placeholder="Password"></input> */}

                        <InputText label='Name' type='text'></InputText>
                        <InputText label='Email' type='email'></InputText>
                        <InputPassword></InputPassword>

                        <Button variant="contained">Sign Up</Button>
                    </form>
                </motion.div>

                {/* ------------------------------------------------------------ */}

                <motion.div
                    // initial={false}
                    animate={{ x: isToggle ? '100%' : 0 }}
                    className='absolute h-[100%] top-0 transition duration-600 ease-in-out left-0 w-[50%] z-2'
                >
                    <form className='bg-[#fff] flex items-center justify-center flex-col h-[100%] px-[40px]'>
                        <h1>Sign In</h1>
                        <div>

                        </div>
                        <span className="text-[12px]">or use your username password</span>
                        {/* <input type="text" placeholder="Username"></input>
                        <input type="password" placeholder="Password"></input> */}

                        <InputText label='Username' type='text'></InputText>
                        <InputPassword></InputPassword>

                        <a className="text-[#333] text-[13px] mt-[15px] mb-[10px]" href="#">Forget Your Account</a>
                        <Button variant="contained">Sign In</Button>
                    </form>
                </motion.div>
                {/* ------------------------------------------------------------ */}

                <motion.div
                    // initial={false}
                    animate={{
                        x: isToggle ? '-100%' : 0,
                        borderRadius: isToggle ? '0 150px 100px 0' : '150px 0 0 100px'
                    }}
                    className='absolute top-0 left-[50%] w-[50%] h-[100%] overflow-hidden transition duration-600 ease-in-out rounded-tl-[150px] rounded-bl-[100px] z-1000'
                >
                    <motion.div
                        // initial={false}
                        animate={{ x: isToggle ? '50%' : 0 }}
                        className='bg-[#512da8] h-[100%] text-[#fff] relative left-[-100%] w-[200%] translate-x-0 transition duration-600 ease-in-out bg-gradient-to-r from-[#FFE0B5] to-[#D8AE7E]'
                    >
                        <motion.div
                            // initial={false}
                            animate={{ x: isToggle ? 0 : '-200%' }}
                            className='absolute w-[50%] h-[100%] flex items-center justify-center flex-col px-[30px] text-center top-0 translate-x-0 transition duration-600 ease-in-out translate-x-[-200%]'
                        >
                            <h1>Welcome Back!</h1>
                            <p className="text-[14px] leading-[20px] tracking-[0.3px] my-[20px]">
                                Enter your personal details to use all of site features
                            </p>
                            <Button onClick={() => { setIsToggle(!isToggle) }} ref={loginRef} className='bg-transparent border-[#fff]' variant="contained">Sign In</Button>
                        </motion.div>

                        <motion.div
                            // initial={false}
                            animate={{ x: isToggle ? '200%' : 0}}
                            className='absolute w-[50%] h-[100%] flex items-center justify-center flex-col px-[30px] text-center top-0 translate-x-0 transition duration-600 ease-in-out right-0 '
                        >
                            <h1>Hello, Friend!</h1>
                            <p className="text-[14px] leading-[20px] tracking-[0.3px] my-[20px]">
                                Register with your personal details to use all of site features
                            </p>
                            <Button onClick={() => { setIsToggle(!isToggle) }} ref={registerRef} className='bg-transparent border-[#fff]' variant="contained">Sign Up</Button>
                        </motion.div>
                    </motion.div>
                </motion.div>
            </div>
        </div>
    )
}

export default Login