import React from "react";
import { useForm } from "react-hook-form";
import './LoginForm.css';

const LoginForm = (props) => {
    const { register, handleSubmit, formState: { errors }, reset } = useForm();

    const onSubmit = (data) => {
        props.onSubmit({
            login: data.name,
            password: data.password,
        });
        reset();
    }

    return (
        <div className="max-w-md mx-auto mt-5 p-5 bg-white rounded shadow">
            <form onSubmit={handleSubmit(onSubmit)}>
                <h1 className="text-xl mb-4">Login</h1>
                
                <div className="mb-3">
                    <label htmlFor="name" className="block mb-1">Name</label>
                    <input 
                        type="text" 
                        id="name" 
                        className="w-full p-2 border rounded"
                        {...register("name", { 
                            required: "Name is required",
                            minLength: { value: 2, message: "Name must be at least 2 characters" }
                        })}
                    />
                    {errors.name && <span className="text-red-500 text-sm">{errors.name.message}</span>}
                </div>
                
                <div className="mb-3">
                    <label htmlFor="password" className="block mb-1">Password</label>
                    <input 
                        type="password" 
                        id="password" 
                        className="w-full p-2 border rounded"
                        {...register("password", { 
                            required: "Password is required",
                            minLength: { value: 6, message: "Password must be at least 6 characters" }
                        })}
                    />
                    {errors.password && <span className="text-red-500 text-sm">{errors.password.message}</span>}
                </div>
                
                <button 
                    type="submit"
                    className="w-full bg-blue-500 text-white p-2 rounded hover:bg-blue-600"
                >
                    Continue
                </button>
            </form>
        </div>
    )
}

export default LoginForm;