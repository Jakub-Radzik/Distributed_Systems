import io.grpc.Server;
import io.grpc.ServerBuilder;
import io.grpc.stub.StreamObserver;

import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import java.util.Vector;

public class GrpcServer {

    public static void main(String[] args) {
        int port = 5001;
        System.out.println("Starting server: ");
        Server server = ServerBuilder
                .forPort(port)
                .addService(new GrpcServiceImpl())
                .build();
        try {
            server.start();
            System.out.println("...server started");
            server.awaitTermination();

        }catch (IOException | InterruptedException e){
            e.printStackTrace();
        }
    }
    static class GrpcServiceImpl extends GrpcServiceGrpc.GrpcServiceImplBase{
        public Map<Integer, Vector<String>> database = new HashMap<>(){};
        public void grpcSavePerson(GrpcRequestSavePerson request, StreamObserver<GrpcResponse> responseStreamObserver){
            String message;
            System.out.println("Saving person");

            Vector<String> values = new Vector<>();

            try{
                values.add("Id: " +request.getId());
                values.add("First name: " +request.getFirstName());
                values.add("Last name: " +request.getLastName());
                values.add("Age: " +request.getAge());

                database.putIfAbsent(request.getId(), values);

                message = "Data added successfully";

            }catch (Exception e){
                message = "Error";
            }

            GrpcResponse response = GrpcResponse.newBuilder()
                    .setMessage(message)
                    .build();
            responseStreamObserver.onNext(response);
            responseStreamObserver.onCompleted();
        }

        public void grpcReadInfo(ReadInfoRequest request, StreamObserver<ReadInfoResponse> response){
            System.out.println("Database: " + database);
            Vector<String> values = database.get(request.getId());
            for (String value : values) {
                ReadInfoResponse response2 = ReadInfoResponse.newBuilder()
                        .setMessage(value)
                        .build();
                response.onNext(response2);
            }
            response.onCompleted();
        }
    }

}
